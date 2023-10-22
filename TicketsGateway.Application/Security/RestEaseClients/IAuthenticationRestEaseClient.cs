using RestEase;
using TicketsGateway.Application.Security.Http.Dto;
using TicketsGateway.Application.Security.Http.Request;

namespace TicketsGateway.Application.Security.RestEaseClients;

public interface IAuthenticationRestEaseClient
{
    [Post("api/v1/Auth/Authenticate")]
    Task<Base.Response<AuthenticateDto>> AuthenticateAsync([Body] AuthenticateRequest authenticateRequest);
}