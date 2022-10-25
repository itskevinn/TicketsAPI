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


    public TicketService(IUnitOfWork unitOfWork, IMapper mapper, ILogger<TicketService> logger,
        IConnectionFactory connectionFactory, IHttpContextAccessor accessor) : base(accessor)

    {
        _ticketRepository = unitOfWork.TicketRepository ??
                            throw new RepoUnavailableException(
                                $"Repo not available {nameof(unitOfWork.TicketRepository)}");
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


    public async Task<Response<TicketDto>> GetByCodeAsync(int code)
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
            var user = await _userRepository.FindByAsync(u => u.Username == request.GeneratedBy);
            if (user is null) throw new UserNotFoundException("This user does not exist");

            SetCurrentUserToEntity(ticket);

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
}