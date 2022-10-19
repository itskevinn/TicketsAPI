using Application.Base;
using Application.Tickets.Http.Dto;
using Application.Tickets.Http.Request;
using AutoMapper;
using Domain.Entity;
using Domain.Ports;
using Infrastructure.Persistence.UnitOfWork;
using Microsoft.Extensions.Logging;

namespace Application.Tickets.Service.Implementation;

public class TicketService : BaseService, ITicketService
{
    private readonly ITicketRepository _ticketRepository;
    private readonly IMapper _mapper;
    private readonly ILogger _logger;

    public TicketService(IUnitOfWork unitOfWork, IMapper mapper, ILogger logger)
    {
        _ticketRepository = unitOfWork.TicketRepository ??
                            throw new ArgumentNullException(nameof(unitOfWork), "Repo not available");
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper), "Mapper not available");
        _logger = logger;
    }

    public async Task<IEnumerable<TicketDto>> GetAllAsync()
    {
        try
        {
            var tickets = await _ticketRepository.GetAsync();
            var ticketDtoList = _mapper.Map<IEnumerable<TicketDto>>(tickets.AsEnumerable());
            return ticketDtoList;
        }
        catch (Exception e)
        {
            _logger.Log(LogLevel.Error, "{AnErrorHappenedMessage} {EMessage}", AnErrorHappenedMessage, e.Message);
            return new List<TicketDto>();
        }
    }

    public async Task<TicketDto> GetByIdAsync(string code)
    {
        try
        {
            var ticket = await _ticketRepository.FindByCodeAsync(code);
            var ticketDtoList = _mapper.Map<TicketDto>(ticket);
            return ticketDtoList;
        }
        catch (Exception e)
        {
            _logger.Log(LogLevel.Error, "{AnErrorHappenedMessage} {EMessage}", AnErrorHappenedMessage, e.Message);
            return null!;
        }
    }

    public Task<TicketDto> CreateAsync(TicketRequest request)
    {
        throw new NotImplementedException();
    }
}