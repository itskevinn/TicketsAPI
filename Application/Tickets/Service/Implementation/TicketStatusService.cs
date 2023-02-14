using System.Net;
using Application.Base;
using Application.Tickets.Http.Dto;
using AutoMapper;
using Domain.Entity;
using Domain.Ports;
using Microsoft.Extensions.Logging;

namespace Application.Tickets.Service.Implementation;

public class TicketStatusService : BaseService<TicketStatus>, ITicketStatusService
{
    private readonly ITicketStatusRepository _ticketStatusRepository;
    private readonly ILogger<TicketStatusService> _logger;
    private readonly IMapper _mapper;

    public TicketStatusService(ILogger<TicketStatusService> logger,
        IMapper mapper, ITicketStatusRepository ticketStatusRepository) : base(mapper)
    {
        _ticketStatusRepository = ticketStatusRepository ??
                                  throw new ArgumentException($"{nameof(ticketStatusRepository)} not available");
        _logger = logger;
        _mapper = mapper;
    }

    public async Task<Response<IEnumerable<TicketStatusDto>>> GetAll()
    {
        try
        {
            var ticketStatuses = await _ticketStatusRepository.GetAsync();
            var ticketStatusesDto = _mapper.Map<IEnumerable<TicketStatusDto>>(ticketStatuses);
            return new Response<IEnumerable<TicketStatusDto>>(HttpStatusCode.OK, "Estados registrados: ", true,
                ticketStatusesDto);
        }
        catch (Exception e)
        {
            _logger.Log(LogLevel.Error, "{AnErrorHappenedMessage} {EMessage}", AnErrorHappenedMessage, e.Message);
            return new Response<IEnumerable<TicketStatusDto>>(HttpStatusCode.InternalServerError,
                AnErrorHappenedMessage, false, null!, e);
        }
    }
}