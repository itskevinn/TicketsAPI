using System.Net;
using Application.Base;
using Application.Exceptions;
using Application.Http.Dto;
using Application.Http.Request;
using AutoMapper;
using Dapper;
using Domain.Entity;
using Domain.Ports;
using Infrastructure.Persistence.Exceptions;
using Infrastructure.Persistence.Factory;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace Application.Service.Implementation;

/// <summary>
/// Class representing the implementation of the <see cref="ITicketService"/> interface
/// </summary>
public class TicketService : BaseService<Ticket>, ITicketService
{
    private readonly ITicketRepository _ticketRepository;
    private readonly IMapper _mapper;
    private readonly ILogger<TicketService> _logger;
    private readonly IConnectionFactory _connectionFactory;
    private readonly ITicketStatusRepository _ticketStatusRepository;

    public TicketService(IMapper mapper, ILogger<TicketService> logger,
        IConnectionFactory connectionFactory, IHttpContextAccessor accessor, ITicketRepository ticketRepository,
        ITicketStatusRepository ticketStatusRepository) : base(accessor, mapper)

    {
        _ticketRepository = ticketRepository ??
                            throw new RepoUnavailableException(
                                $"Repo not available {nameof(ticketRepository)}");
        _ticketStatusRepository = ticketStatusRepository ??
                                  throw new RepoUnavailableException(
                                      $"Repo not available {nameof(ticketStatusRepository)}");
        _mapper = mapper ?? throw new RepoUnavailableException("Mapper not available");
        _logger = logger;
        _connectionFactory = connectionFactory;
    }

    public async Task<Response<IEnumerable<TicketDto>>> GetAllAsync()
    {
        try
        {
            var tickets = await _ticketRepository.GetAsync(null, null, false,
                "TicketStatus,TicketDetails,TicketDetails.Attachments");
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
            ticket.GeneratedOn = DateTime.Today;

            var foundStatus = await _ticketStatusRepository.FindAsync(request.StatusId);
            if (foundStatus == null)
            {
                throw new TicketStatusNotFoundException(
                    $"The given status id: {request.StatusId} was not found in the status repository");
            }

            ticket.TicketStatus = foundStatus;
            
            //TODO: Validate from users microservice
            var foundUser = new UserTicketDto();
            if (request.AssignedTo != string.Empty && foundUser == null)
                throw new UserNotFoundException($"User {request.AssignedTo} was not found");

            ticket = await _ticketRepository.CreateAsync(ticket);

            var ticketDto = _mapper.Map<TicketDto>(ticket);
            ticketDto.AssignedTo = _mapper.Map<UserTicketDto>(foundUser);

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

    public Response<IEnumerable<UserTicketDto>> GetAllAvailableUsersAsync()
    {
        try
        {
            //TODO: Get users from users microservice
            var usersDto = new List<UserTicketDto>();
            return new Response<IEnumerable<UserTicketDto>>(HttpStatusCode.OK, "Ticket registered successfully",
                true, usersDto);
        }
        catch (Exception e)
        {
            _logger.Log(LogLevel.Error, "{AnErrorHappenedMessage} {EMessage}", AnErrorHappenedMessage, e.Message);
            return new Response<IEnumerable<UserTicketDto>>(HttpStatusCode.InternalServerError, AnErrorHappenedMessage,
                false, new List<UserTicketDto>(), e);
        }
    }
}