using System.Net;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using TicketsGateway.Application.Base;
using TicketsGateway.Application.Core.Helpers;
using TicketsGateway.Application.RestEaseClients;
using TicketsGateway.Application.Security.Http.Dto;
using TicketsGateway.Application.Security.Http.Request;

namespace TicketsGateway.Application.Security.Services.Implementation;

public class UserService : BaseService, IUserService
{
    private readonly IUserRestEaseClient _userRestEaseClient;
    private readonly ILogger<UserService> _logger;

    public UserService(IOptions<AppSettings> appSettings, ILogger<UserService> logger)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _userRestEaseClient =
            RestEase.RestClient.For<IUserRestEaseClient>(appSettings.Value.MicroservicesUrls.SecurityUrl);
    }

    public async Task<Response<UserDto>> GetById(Guid id, string token)
    {
        try
        {
            return await _userRestEaseClient.GetById(id,token);
        }
        catch (Exception e)
        {
            _logger.Log(LogLevel.Error, "{AnErrorHappenedMessage} {EMessage}", AnErrorHappenedMessage, e.Message);
            return new Response<UserDto>(HttpStatusCode.InternalServerError, AnErrorHappenedMessage, false, null!, e);
        }
    }

    public async Task<Response<IEnumerable<UserDto>>> GetAll(string token)
    {
        try
        {
            return await _userRestEaseClient.GetAll(token);
        }
        catch (Exception e)
        {
            _logger.Log(LogLevel.Error, "{AnErrorHappenedMessage} {EMessage}", AnErrorHappenedMessage, e.Message);
            return new Response<IEnumerable<UserDto>>(HttpStatusCode.InternalServerError, AnErrorHappenedMessage, false,
                null!, e);
        }
    }

    public async Task<Response<UserDto>> Save(UserRequest userRequest, string token)
    {
        try
        {
            return await _userRestEaseClient.Save(userRequest,token);
        }
        catch (Exception e)
        {
            _logger.Log(LogLevel.Error, "{AnErrorHappenedMessage} {EMessage}", AnErrorHappenedMessage, e.Message);
            return new Response<UserDto>(HttpStatusCode.InternalServerError, AnErrorHappenedMessage, false,
                null!, e);
        }
    }
}