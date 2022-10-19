using System.Net;
using Application.Base;
using Application.Security.Http.Dto;
using Application.Security.Http.Request;
using AutoMapper;
using Domain.Entity;
using Domain.Ports;
using Infrastructure.Core.Response;
using Infrastructure.Persistence.UnitOfWork;
using Infrastructure.Security.Encrypt;
using Microsoft.AspNetCore.Http;

namespace Application.Security.Service.Implementation;

public class UserService : BaseService, IUserService
{
    private readonly IGenericRepository<User> _userRepository;
    private readonly IMapper _mapper;
    private readonly IGenericRepository<UserRole> _userRoleRepository;
    private readonly IGenericRepository<MenuItem> _menuItemRepository;
    private readonly IGenericRepository<MenuItemRole> _menuItemRoleRepository;

    public UserService(IMapper mapper,
        IUnitOfWork unitOfWork,
        IHttpContextAccessor accessor
    ) : base(accessor)
    {
        _mapper = mapper ?? throw new ArgumentNullException($"{nameof(mapper)}");
        _userRepository = unitOfWork.UserRepository ??
                          throw new ArgumentNullException($"{nameof(unitOfWork)}");
        _menuItemRepository = unitOfWork.MenuItemRepository ?? throw new ArgumentNullException($"{nameof(unitOfWork)}");
    }

    public async Task<Response<UserDto>> Save(UserRequest userRequest)
    {
        try
        {
            var user = _mapper.Map<User>(userRequest);
            user.Password = Hash.GetSha256(user.Password);
            user = await _userRepository.CreateAsync(user);
            await _userRoleRepository.CreateAsync(new UserRole(user.Id, userRequest.RoleId));
            var userDto = _mapper.Map<UserDto>(user);
            return new Response<UserDto>(HttpStatusCode.OK, "Usuario registrado", true, userDto);
        }
        catch (Exception e)
        {
            return new Response<UserDto>(HttpStatusCode.InternalServerError, AnErrorHappenedMessage, false, null!, e);
        }
    }

    public async Task<Response<IEnumerable<UserDto>>> GetAll()
    {
        try
        {
            var users = await _userRepository.GetAsync(null, null, false, "UserRoles,UserRoles.Role");
            var userDtoList = _mapper.Map<IEnumerable<UserDto>>(users);
            return new Response<IEnumerable<UserDto>>
                (HttpStatusCode.OK, "Usuarios encontrados", true, userDtoList);
        }
        catch (Exception e)
        {
            return new Response<IEnumerable<UserDto>>(HttpStatusCode.InternalServerError, AnErrorHappenedMessage,
                false, null!, e);
        }
    }

    public async Task<Response<UserDto>> FindById(Guid id)
    {
        var currentUser = GetCurrentUser();
        if (currentUser == null!)
            return new Response<UserDto>(HttpStatusCode.Unauthorized, "Sesión caducada", false);
        if (id != currentUser.Id &&
            currentUser.Roles?.First(r => r.RoleName == "Admin").RoleName != "Admin")
            return new Response<UserDto>(HttpStatusCode.Unauthorized, "No está autorizado", false);
        return await GetById(id);
    }

    public async Task<Response<UserDto>> GetById(Guid id)
    {
        try
        {
            var user = await _userRepository.Find(u => u.Id == id, false, "UserRoles");
            var userDto = await SetUserRoles(user);
            var authorities = new List<MenuItem>();
            SetRoleAuthorities(userDto, authorities);
            return new Response<UserDto>
                (HttpStatusCode.OK, "Usuario encontrado", true, userDto);
        }
        catch (Exception e)
        {
            return new Response<UserDto>(HttpStatusCode.InternalServerError, AnErrorHappenedMessage,
                false, null!, e);
        }
    }

    private async Task<UserDto> SetUserRoles(User user)
    {
        var userRoles =
            await _userRoleRepository.GetAsync(ur => ur.UserId == user.Id, null, false, "Role");
        var roles = new List<Role>();
        userRoles.ToList().ForEach(u => { roles.Add(u.Role); });
        user.Roles = roles;
        var userDto = _mapper.Map<UserDto>(user);
        return userDto;
    }

    private void SetRoleAuthorities(UserDto userDto, ICollection<MenuItem> authorities)
    {
        foreach (var userDtoRole in userDto.Roles)
        {
            var roleMenuItems =
                _menuItemRoleRepository.GetAsync(m => m.RoleId == userDtoRole.Id).Result.ToList();
            roleMenuItems.ForEach(r =>
            {
                authorities.Add(_menuItemRepository.GetAsync(m => m.Id == r.MenuItemId).Result.MinBy(m => m.Order) ??
                                throw new InvalidOperationException());
            });
            var authoritiesDto = _mapper.Map<IEnumerable<MenuItemDto>>(authorities);
            userDtoRole.Authorities = authoritiesDto;
        }
    }
}