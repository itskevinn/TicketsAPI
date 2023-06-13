using TicketsGateway.Application.Base;
using TicketsGateway.Application.Security.Http.Dto;
using TicketsGateway.Application.Security.Http.Request;
using TicketsGateway.Infrastructure.Core.Interface;

namespace TicketsGateway.Application.Security.Services;

public interface IAuthenticationService : IScopedService
{
    /// <summary>
    /// Method in which authentication is performed.
    /// </summary>
    /// <param name="authenticateRequest" cref="AuthenticateRequest"> Request model of auth sent by client</param>
    /// <returns><see cref="Response{T}"/><see cref="AuthenticateRequest"/></returns>
    Task<Response<AuthenticateDto>> AuthenticateAsync(AuthenticateRequest authenticateRequest);
}