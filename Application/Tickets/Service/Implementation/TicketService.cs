using System.Net;
using Application.Base;
using Application.Exceptions;
using Application.Tickets.Http.Dto;
using Application.Tickets.Http.Request;
using AutoMapper;
using Dapper;
using Domain.Entity;
using Domain.Ports;
using Infrastructure.Persistence.Exceptions;
using Infrastructure.Persistence.Factory;
using Infrastructure.Persistence.UnitOfWork;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace Application.Tickets.Service.Implementation;

/// <summary>
/// Class representing the implementation of the <see cref="ITicketService"/> interface
/// </summary>
public class TicketService : BaseService<Ticket>, ITicketService
{
    private readonly ITicketRepository _ticketRepository;
    private readonly IMapper _mapper;
    private readonly ILogger<TicketService> _logger;
    private readonly IUserRepository _userRepository;
    private readonly IConnectionFactory _connectionFactory;
    private readonly IUnitOfWork _unitOfWork;


    public TicketService(IUnitOfWork unitOfWork, IMapper mapper, ILogger<TicketService> logger,
        IConnectionFactory connectionFactory, IHttpContextAccessor accessor) : base(accessor)

    {
        _ticketRepository = unitOfWork.TicketRepository ??
                            throw new RepoUnavailableException(
                                $"Repo not available {nameof(unitOfWork.TicketRepository)}");
        _unitOfWork = unitOfWork;
        _mapper = mapper ?? throw new RepoUnavailableException("Mapper not available");
        _logger = logger;
        _connectionFactory = connectionFactory;
        _userRepository = unitOfWork.UserRepository ?? throw new RepoUnavailableException(
            $"Repo not available {nameof(unitOfWork.TicketRepository)}");
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


    public Response<TicketDto> GetByCodeAsync(int code)
    {
        try
        {
            var ticket = _ticketRepository.FindByCode(code);
            var foundTicket = _mapper.Map<TicketDto>(ticket);
            return new Response<TicketDto>(HttpStatusCode.OK, "Found ticket: ",
                true, foundTicket);
        }
        catch (Exception e)
        {
            _logger.Log(LogLevel.Error, "{AnErrorHappenedMessage} {EMessage}", AnErrorHappenedMessage, e.Message);
            return new Response<TicketDto>(HttpStatusCode.InternalServerError, AnErrorHappenedMessage,
                false, new TicketDto(), e);
        }
    }


    public async Task<Response<TicketDto>> GetByIdAsync(Guid id)
    {
        try
        {
            var ticket = await _ticketRepository.FindAsync(id);
            var foundTicket = _mapper.Map<TicketDto>(ticket);
            return new Response<TicketDto>(HttpStatusCode.OK, "Found ticket: ",
                true, foundTicket);
        }
        catch (Exception e)
        {
            _logger.Log(LogLevel.Error, "{AnErrorHappenedMessage} {EMessage}", AnErrorHappenedMessage, e.Message);
            return new Response<TicketDto>(HttpStatusCode.InternalServerError, AnErrorHappenedMessage,
                false, new TicketDto(), e);
        }
    }

    public async Task<Response<TicketDto>> CreateAsync(TicketRequest request)
    {
        try
        {
            const string sqlGetCode = "SELECT \"sq_ticket_code\".NEXTVAL FROM DUAL";
            var conn = _connectionFactory.Connection ??
                       throw new DatabaseUnavailableException($"{nameof(_connectionFactory.Connection)}");

            var ticket = _mapper.Map<Ticket>(request);
            ticket.Code = await conn.QueryFirstAsync<int>(sqlGetCode);
            SetCurrentUserToEntity(ticket);
            var userExists = _userRepository.ExistsByUsername(ticket.GeneratedBy);
            if (!userExists) throw new UserNotFoundException("This user does not exist");

            ticket = await _ticketRepository.CreateAsync(ticket);
            var ticketDto = _mapper.Map<TicketDto>(ticket);
            return new Response<TicketDto>(HttpStatusCode.OK, "Ticket registered successfully",
                true, ticketDto);
        }
        catch (Exception e)
        {
            _logger.Log(LogLevel.Error, "{AnErrorHappenedMessage} {EMessage}", AnErrorHappenedMessage, e.Message);
            return new Response<TicketDto>(HttpStatusCode.InternalServerError, AnErrorHappenedMessage,
                false, new TicketDto(), e);
        }
    }

    public Response<TicketDto> Update(UpdateTicketRequest request)
    {
        try
        {
            var oldTicket = _ticketRepository.FindBy(a => a.Code.Equals(request.Code));
            if (oldTicket == null)
                throw new TicketNotFoundException("Ticket not found");
            var ticket = _mapper.Map<Ticket>(request);
            ticket.Id = oldTicket.Id;
            ticket.CreatedBy = oldTicket.CreatedBy;
            ticket.CreatedOn = oldTicket.CreatedOn;
            _unitOfWork.ClearTracking();
            _ticketRepository.Update(ticket);
            var ticketDto = _mapper.Map<TicketDto>(ticket);
            return new Response<TicketDto>(HttpStatusCode.OK, "Ticket updated successfully", true, ticketDto);
        }
        catch (Exception e)
        {
            _logger.Log(LogLevel.Error, "{AnErrorHappenedMessage} {EMessage}", AnErrorHappenedMessage, e.Message);
            return new Response<TicketDto>(HttpStatusCode.InternalServerError, AnErrorHappenedMessage,
                false, new TicketDto(), e);
        }
    }

    public async Task<Response<bool>> UpdateStatusAsync(string newState, int code)
    {
        try
        {
            var ticketExists = _ticketRepository.FindByCode(code) != null;
            if (!ticketExists)
                throw new TicketNotFoundException("Ticket not found");
            _unitOfWork.ClearTracking();
            await _ticketRepository.UpdateState(newState, code);
            return new Response<bool>(HttpStatusCode.OK, "Ticket updated successfully", true, true);
        }
        catch (Exception e)
        {
            _logger.Log(LogLevel.Error, "{AnErrorHappenedMessage} {EMessage}", AnErrorHappenedMessage, e.Message);
            return new Response<bool>(HttpStatusCode.InternalServerError, AnErrorHappenedMessage,
                false, false, e);
        }
    }
}