using System.Net;
using Application.Base;
using Application.Tickets.Http.Dto;
using Application.Tickets.Http.Request;
using AutoMapper;
using Domain.Ports;
using Infrastructure.Persistence.Exceptions;
using Infrastructure.Persistence.UnitOfWork;
using Microsoft.Extensions.Logging;

namespace Application.Tickets.Service.Implementation;

public class TicketService : BaseService, ITicketService
{
    private readonly ITicketRepository _ticketRepository;
    private readonly IMapper _mapper;
    private readonly ILogger<TicketService> _logger;

    public TicketService(IUnitOfWork unitOfWork, IMapper mapper, ILogger<TicketService> logger)
    {
        _ticketRepository = unitOfWork.TicketRepository ??
                            throw new RepositoryUnavailableException(
                                $"Repo not available {nameof(unitOfWork.TicketRepository)}");
        _mapper = mapper ?? throw new RepositoryUnavailableException("Mapper not available");
        _logger = logger;
    }

    public async Task<Response<IEnumerable<TicketDto>>> GetAllAsync()
    {
        try
        {
            var tickets = await _ticketRepository.GetAsync();
            var ticketDtoList = _mapper.Map<IEnumerable<TicketDto>>(tickets.AsEnumerable());
            return new Response<IEnumerable<TicketDto>>(HttpStatusCode.OK, "Found tickets: ",
                true, ticketDtoList);
        }
        catch (Exception e)
        {
            _logger.Log(LogLevel.Error, "{AnErrorHappenedMessage} {EMessage}", AnErrorHappenedMessage, e.Message);
            return new Response<IEnumerable<TicketDto>>(HttpStatusCode.InternalServerError, AnErrorHappenedMessage,
                false, new List<TicketDto>(), e);
        }
    }

    public async Task<Response<TicketDto>> GetByIdAsync(string code)
    {
        try
        {
            var ticket = await _ticketRepository.FindByCodeAsync(code);
            var foundTicket = _mapper.Map<TicketDto>(ticket);
            return new Response<TicketDto>(HttpStatusCode.OK, "Found ticket: ",
                true, foundTicket);
        }
        catch (Exception e)
        {
            _logger.Log(LogLevel.Error, "{AnErrorHappenedMessage} {EMessage}", AnErrorHappenedMessage, e.Message);
            return null!;
        }
    }

    public Task<Response<TicketDto>> CreateAsync(TicketRequest request)
    {
        throw new NotImplementedException();
    }
}