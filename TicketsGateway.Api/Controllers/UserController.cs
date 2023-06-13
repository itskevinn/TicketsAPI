using Microsoft.AspNetCore.Mvc;
using TicketsGateway.Application.Base;
using TicketsGateway.Application.Security;
using TicketsGateway.Application.Security.Http.Dto;
using TicketsGateway.Application.Security.Http.Request;
using TicketsGateway.Application.Security.Services;

namespace TicketsGateway.Api.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class UserController : Controller
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [Authorize(new[] { "Admin" })]
    [HttpGet("FindAll")]
    public async Task<Response<IEnumerable<UserDto>>> GetAll()
    {
        return await _userService.GetAll();
    }

    [Authorize(new[] { "Admin" })]
    [HttpGet("FindById/{id:guid}")]
    public async Task<Response<UserDto>> GetById(Guid id)
    {
        return await _userService.GetById(id);
    }

    [Authorize(new[] { "Admin" })]
    [HttpPost("Create")]
    public async Task<Response<UserDto>> Save(UserRequest userRequest)
    {
        return await _userService.Save(userRequest);
    }
}