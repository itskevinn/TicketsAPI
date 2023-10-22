using System.Net;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using TicketsGateway.Application.Base;
using TicketsGateway.Application.Core.Helpers;
using TicketsGateway.Application.Security.Http.Dto;
using TicketsGateway.Application.Security.Http.Request;
using TicketsGateway.Application.Security.RestEaseClients;

namespace TicketsGateway.Application.Security.Services.Implementation;

public class AuthenticationService : BaseService, IAuthenticationService
{
    private readonly IAuthenticationRestEaseClient _authenticationRestClient;
    private readonly ILogger<AuthenticationService> _logger;

    public AuthenticationService(IOptions<AppSettings> appSettings, ILogger<AuthenticationService> logger,
        IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
    {
        _logger = logger;
        _authenticationRestClient =
            RestEase.RestClient.For<IAuthenticationRestEaseClient>(appSettings.Value.MicroservicesUrls.SecurityUrl);
    }

    public async Task<Response<AuthenticateDto>> AuthenticateAsync(AuthenticateRequest authenticateRequest)
    {
        try
        {
            var authenticatedUserDto = await _authenticationRestClient.AuthenticateAsync(authenticateRequest);
            return authenticatedUserDto;
        }
        catch (Exception e)
        {
            _logger.Log(LogLevel.Error, "{AnErrorHappenedMessage} {EMessage}", AnErrorHappenedMessage, e.Message);
            return new Response<AuthenticateDto>(HttpStatusCode.InternalServerError,
                AnErrorHappenedMessage,
                false, null!, e);
        }
    }
}