using System.Net;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using TicketsGateway.Application.Base;
using TicketsGateway.Application.Core.Helpers;
using TicketsGateway.Application.TicketManagement.Http.Dto;
using TicketsGateway.Application.TicketManagement.Http.Request;
using TicketsGateway.Application.TicketManagement.RestEaseClients;

namespace TicketsGateway.Application.TicketManagement.Service.Implementation;

/// <summary>
/// Class representing the implementation of the <see cref="ITicketService"/> interface
/// </summary>
public class TicketService : BaseService, ITicketService
{
    private readonly ITicketRestEaseClient _ticketRestEaseClient;
    private readonly ILogger<TicketService> _logger;

    public TicketService(ILogger<TicketService> logger, IOptions<AppSettings> appSettings,
        IHttpContextAccessor accessor) : base(accessor)

    {
        _ticketRestEaseClient =
            RestEase.RestClient.For<ITicketRestEaseClient>(appSettings.Value.MicroservicesUrls.TicketsManagementUrl);
        _logger = logger;
    }

    public async Task<Response<IEnumerable<TicketDto>>> GetAllAsync(string token)
    {
        try
        {
            return await _ticketRestEaseClient.GetAllAsync(token);
        }
        catch (Exception e)
        {
            _logger.Log(LogLevel.Error, "{AnErrorHappenedMessage} {EMessage}", AnErrorHappenedMessage, e.Message);
            return new Response<IEnumerable<TicketDto>>(HttpStatusCode.InternalServerError, AnErrorHappenedMessage,
                false, new List<TicketDto>(), e);
        }
    }


    public async Task<Response<TicketDto>> GetByCodeAsync(int code, string token)
    {
        try
        {
            return await _ticketRestEaseClient.GetByCodeAsync(code, token);
        }
        catch (Exception e)
        {
            _logger.Log(LogLevel.Error, "{AnErrorHappenedMessage} {EMessage}", AnErrorHappenedMessage, e.Message);
            return new Response<TicketDto>(HttpStatusCode.InternalServerError, AnErrorHappenedMessage,
                false, new TicketDto(), e);
        }
    }


    public async Task<Response<TicketDto>> GetByIdAsync(Guid id, string token)
    {
        try
        {
            return await _ticketRestEaseClient.GetByIdAsync(id, token);
        }
        catch (Exception e)
        {
            _logger.Log(LogLevel.Error, "{AnErrorHappenedMessage} {EMessage}", AnErrorHappenedMessage, e.Message);
            return new Response<TicketDto>(HttpStatusCode.InternalServerError, AnErrorHappenedMessage,
                false, new TicketDto(), e);
        }
    }

    public async Task<Response<TicketDto>> CreateAsync(TicketRequest request, string token)
    {
        try
        {
            return await _ticketRestEaseClient.CreateAsync(request, token);
        }
        catch (Exception e)
        {
            _logger.Log(LogLevel.Error, "{AnErrorHappenedMessage} {EMessage}", AnErrorHappenedMessage, e.Message);
            return new Response<TicketDto>(HttpStatusCode.InternalServerError, AnErrorHappenedMessage,
                false, new TicketDto(), e);
        }
    }

    public async Task<Response<TicketDto>> Update(UpdateTicketRequest request, string token)
    {
        try
        {
            return await _ticketRestEaseClient.Update(request, token);
        }
        catch (Exception e)
        {
            _logger.Log(LogLevel.Error, "{AnErrorHappenedMessage} {EMessage}", AnErrorHappenedMessage, e.Message);
            return new Response<TicketDto>(HttpStatusCode.InternalServerError, AnErrorHappenedMessage,
                false, new TicketDto(), e);
        }
    }

    public async Task<Response<bool>> UpdateStatusAsync(string newState, int code, string token)
    {
        try
        {
            return await _ticketRestEaseClient.UpdateStatusAsync(newState, code, token);
        }
        catch (Exception e)
        {
            _logger.Log(LogLevel.Error, "{AnErrorHappenedMessage} {EMessage}", AnErrorHappenedMessage, e.Message);
            return new Response<bool>(HttpStatusCode.InternalServerError, AnErrorHappenedMessage,
                false, false, e);
        }
    }

    public async Task<Response<IEnumerable<UserTicketDto>>> GetAllAvailableUsersAsync(string token)
    {
        try
        {
            return await _ticketRestEaseClient.GetAllAvailableUsersAsync(token);
        }
        catch (Exception e)
        {
            _logger.Log(LogLevel.Error, "{AnErrorHappenedMessage} {EMessage}", AnErrorHappenedMessage, e.Message);
            return new Response<IEnumerable<UserTicketDto>>(HttpStatusCode.InternalServerError, AnErrorHappenedMessage,
                false, new List<UserTicketDto>(), e);
        }
    }
}