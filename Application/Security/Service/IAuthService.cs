using Application.Base;
using Application.Security.Http.Dto;
using Application.Security.Http.Request;
using Infrastructure.Core.Interface;

namespace Application.Security.Service;

public interface IAuthService : IScopedService
{
    /// <summary>
    /// Method in which authentication is performed.
    /// </summary>
    /// <param name="authenticateRequest" cref="AuthenticateRequest"> Request model of auth sent by client</param>
    /// <returns><see cref="Response{T}"/><see cref="AuthenticateRequest"/></returns>
    Task<Response<AuthenticateDto>> Authenticate(AuthenticateRequest authenticateRequest);
}