using System.Net;
using System.Net.Mail;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using TicketsGateway.Application.TicketManagement.Http.Dto;
using TicketsGateway.Application.TicketManagement.Http.Request;
using TicketsGateway.Application.TicketManagement.RestEaseClients;
using TicketsGateway.Application.Base;
using TicketsGateway.Application.Core.Helpers;

namespace TicketsGateway.Application.TicketManagement.Service.Implementation;

public class TicketDetailService : BaseService, ITicketDetailService
{
    private readonly ILogger<TicketDetailService> _logger;
    private readonly ITicketDetailRestEaseClient _ticketDetailRestEaseClient;

    public TicketDetailService(ILogger<TicketDetailService> logger, AppSettings appSettings,
        IHttpContextAccessor accessor) :
        base(accessor)
    {
        _logger = logger;
        RestEase.RestClient.For<ITicketRestEaseClient>(appSettings.MicroservicesUrls.TicketsManagementUrl);
        _ticketDetailRestEaseClient =
            RestEase.RestClient.For<ITicketDetailRestEaseClient>(appSettings.MicroservicesUrls.TicketsManagementUrl);
    }

    public async Task<Response<IEnumerable<TicketDetailDto>>> GetAllByTicketCode(int ticketCode, string token)
    {
        try
        {
            var ticketDetailDtoList = await _ticketDetailRestEaseClient.GetAllByTicketCode(ticketCode, token);
            return new Response<IEnumerable<TicketDetailDto>>(HttpStatusCode.OK, "Found details", true,
                ticketDetailDtoList.Data);
        }
        catch (Exception e)
        {
            _logger.Log(LogLevel.Error, "{AnErrorHappenedMessage} {EMessage}", AnErrorHappenedMessage, e.Message);
            return new Response<IEnumerable<TicketDetailDto>>(HttpStatusCode.InternalServerError,
                AnErrorHappenedMessage,
                false, new List<TicketDetailDto>(), e);
        }
    }

    public async Task<Response<IEnumerable<TicketDetailDto>>> GetAllByTicketId(Guid ticketId, string token)
    {
        try
        {
            var ticketDetailDtoList = await _ticketDetailRestEaseClient.GetAllByTicketId(ticketId, token);
            return new Response<IEnumerable<TicketDetailDto>>(HttpStatusCode.OK, "Found details", true,
                ticketDetailDtoList.Data);
        }
        catch (Exception e)
        {
            _logger.Log(LogLevel.Error, "{AnErrorHappenedMessage} {EMessage}", AnErrorHappenedMessage, e.Message);
            return new Response<IEnumerable<TicketDetailDto>>(HttpStatusCode.InternalServerError,
                AnErrorHappenedMessage,
                false, new List<TicketDetailDto>(), e);
        }
    }

    public async Task<Response<TicketDetailDto>> CreateAsync(TicketDetailRequest request, string token)
    {
        try
        {
            var ticketDetail = await _ticketDetailRestEaseClient.Create(request, token);
            return new Response<TicketDetailDto>(HttpStatusCode.OK, "Found details", true,
                ticketDetail.Data);
        }
        catch (Exception e)
        {
            _logger.Log(LogLevel.Error, "{AnErrorHappenedMessage} {EMessage}", AnErrorHappenedMessage, e.Message);
            return new Response<TicketDetailDto>(HttpStatusCode.InternalServerError,
                AnErrorHappenedMessage,
                false, null!, e);
        }
    }

    public async Task<Response<TicketDetailDto>> UpdateAsync(UpdateTicketDetailRequest request, string token)
    {
        try
        {
            var ticketDetail = await _ticketDetailRestEaseClient.Update(request, token);
            return new Response<TicketDetailDto>(HttpStatusCode.OK, "Found details", true,
                ticketDetail.Data);
        }
        catch (Exception e)
        {
            _logger.Log(LogLevel.Error, "{AnErrorHappenedMessage} {EMessage}", AnErrorHappenedMessage, e.Message);
            return new Response<TicketDetailDto>(HttpStatusCode.InternalServerError,
                AnErrorHappenedMessage,
                false, null!, e);
        }
    }

    public async Task<Response<bool>> Delete(Guid ticketDetailId, string token)
    {
        try
        {
            var ticketDetail = await _ticketDetailRestEaseClient.Delete(ticketDetailId, token);
            return new Response<bool>(HttpStatusCode.OK, "Found details", true,
                ticketDetail.Data);
        }
        catch (Exception e)
        {
            _logger.Log(LogLevel.Error, "{AnErrorHappenedMessage} {EMessage}", AnErrorHappenedMessage, e.Message);
            return new Response<bool>(HttpStatusCode.InternalServerError,
                AnErrorHappenedMessage,
                false, false, e);
        }
    }
}