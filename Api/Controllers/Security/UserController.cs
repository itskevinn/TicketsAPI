using Application.Base;
using Application.Security.Http.Dto;
using Application.Security.Http.Request;
using Application.Security.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TicketsWebServices.Controllers.Security;

[ApiController]
[Route("api/v1/[controller]")]
public class UserController : Controller
{
    private readonly IUserService _userService;
    private readonly IAuthService _authService;

    public UserController(IUserService userService, IAuthService authService)
    {
        _authService = authService;
        _userService = userService;
    }

    [AllowAnonymous]
    [HttpPost("Authenticate")]
    public async Task<Response<AuthenticateDto>> Authenticate(AuthenticateRequest authenticateRequest)
    {
        return await _authService.Authenticate(authenticateRequest);
    }

    [Application.Security.Authorize(new[] { "Admin" })]
    [HttpGet("FindAll")]
    public async Task<Response<IEnumerable<UserDto>>> GetAll()
    {
        return await _userService.GetAll();
    }

    [Application.Security.Authorize(new[] { "Admin" })]
    [HttpGet("FindById/{id:guid}")]
    public async Task<Response<UserDto>> GetById(Guid id)
    {
        return await _userService.GetById(id);
    }

    [Application.Security.Authorize(new[] { "Admin" })]
    [HttpPost("SaveAsync")]
    public async Task<Response<UserDto>> Save(UserRequest userRequest)
    {
        return await _userService.Save(userRequest);
    }
}