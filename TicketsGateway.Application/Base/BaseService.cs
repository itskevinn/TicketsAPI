using Microsoft.AspNetCore.Http;
using TicketsGateway.Application.Security.Http.Dto;

namespace TicketsGateway.Application.Base;

public class BaseService
{
    protected const string AnErrorHappenedMessage = "Ocurrió un error";
    private readonly IHttpContextAccessor? _contextAccessor;

    protected BaseService(IHttpContextAccessor context)
    {
        _contextAccessor = context;
    }

    protected BaseService()
    {
    }

    protected UserDto GetCurrentUser()
    {
        return (UserDto)_contextAccessor?.HttpContext?.Items["User"]!;
    }
}