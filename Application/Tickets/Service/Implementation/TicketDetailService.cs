using Application.Base;
using Application.Tickets.Http.Dto;
using Application.Tickets.Http.Request;
using Domain.Entity;
using Domain.Ports;
using Infrastructure.Persistence.Exceptions;
using Infrastructure.Persistence.UnitOfWork;
using Microsoft.Extensions.Logging;

namespace Application.Tickets.Service.Implementation;

public class TicketDetailService : BaseService<TicketDetail>, ITicketDetailService
{
    private readonly ILogger _logger;
    private readonly ITicketDetailRepository _ticketDetailRepository;

    public TicketDetailService(IUnitOfWork unitOfWork, ILogger logger)
    {
        _logger = logger;
        _ticketDetailRepository = unitOfWork.TicketDetailRepository ?? throw new RepoUnavailableException(
            $"Repo not available {nameof(unitOfWork.TicketDetailRepository)}");
    }

    public Task<Response<IEnumerable<TicketDetailDto>>> GetAllByTicketCode(int ticketCode)
    {
        throw new NotImplementedException();
    }

    public Task<Response<TicketDetailDto>> CreateAsync(TicketDetailRequest request)
    {
        throw new NotImplementedException();
    }

    public void Update(UpdateTicketDetailRequest request)
    {
        throw new NotImplementedException();
    }

    public Task<Response<TicketDetailDto>> Delete(TicketDetailRequest request)
    {
        throw new NotImplementedException();
    }
}