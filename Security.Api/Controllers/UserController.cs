using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Security.Application.Base;
using Security.Application.Http.Dto;
using Security.Application.Http.Request;
using Security.Application.Service;

namespace Security.Api.Controllers;

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

    [HttpGet("FindAll")]
    public async Task<Response<IEnumerable<UserDto>>> GetAll()
    {
        return await _userService.GetAll();
    }

    [HttpGet("FindById/{id:guid}")]
    public async Task<Response<UserDto>> GetById(Guid id)
    {
        return await _userService.GetById(id);
    }

    [HttpPost("SaveAsync")]
    public async Task<Response<UserDto>> Save(UserRequest userRequest)
    {
        return await _userService.Save(userRequest);
    }
}