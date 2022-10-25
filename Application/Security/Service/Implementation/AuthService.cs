using System.Net;
using Application.Base;
using Application.Security.Http.Dto;
using Application.Security.Http.Request;
using AutoMapper;
using Domain.Entity;
using Domain.Ports;
using Infrastructure.Persistence.Exceptions;
using Infrastructure.Persistence.UnitOfWork;
using Infrastructure.Security.Encrypt;
using Infrastructure.Security.Jwt;

namespace Application.Security.Service.Implementation;

public class AuthService : BaseService<User>, IAuthService
{
    private readonly IUserRepository _userRepository;
    private readonly IUserRoleRepository _userRoleRepository;
    private readonly IMapper _mapper;
    private readonly IJwtUtils<UserDto> _jwtUtils;
    private readonly IUserService _userService;

    public AuthService(IUserService userService, IMapper mapper, IJwtUtils<UserDto> jwtUtils, IUnitOfWork unitOfWork)
    {
        _userRepository = unitOfWork.UserRepository ??
                          throw new RepoUnavailableException($"{nameof(unitOfWork.RoleRepository)}");

        _userRoleRepository = unitOfWork.UserRoleRepository ??
                              throw new RepoUnavailableException($"{nameof(unitOfWork.UserRoleRepository)}");
        _userService = userService;
        _mapper = mapper;
        _jwtUtils = jwtUtils;
    }

    public async Task<Response<AuthenticateDto>> Authenticate(AuthenticateRequest authenticateRequest)
    {
        var users = await _userRepository.GetAsync();
        var user = users.SingleOrDefault(x =>
            string.Equals(x.Username.ToLower(), authenticateRequest.Username.ToLower()) &&
            x.Password == Hash.GetSha256(authenticateRequest.Password));
        if (user == null)
            return new Response<AuthenticateDto>(HttpStatusCode.Unauthorized, "Usuario o contraseña incorrectos",
                false);
        var userDto = await _userService.GetById(user.Id);
        var token = _jwtUtils.GenerateJwtToken(userDto.Data);
        return new Response<AuthenticateDto>(HttpStatusCode.OK, "Bienvenido", true,
            new AuthenticateDto(userDto.Data, token));
    }

    public async Task<UserDto> GetOnlyUserById(Guid id)
    {
        var user = await _userRepository.FindByAsync(u => u.Id == id, false, "UserRoles");
        var userRoles =
            await _userRoleRepository.GetAsync(ur => ur.UserId == user.Id, null, false, "Role");
        var roles = new List<Role>();
        userRoles.ToList().ForEach(u => { roles.Add(u.Role); });
        user.Roles = roles;
        var userDto = _mapper.Map<UserDto>(user);
        return userDto;
    }
}