using Application.Base;
using Application.Tickets.Http.Dto;
using Application.Tickets.Http.Request;
using Infrastructure.Core.Interface;

namespace Application.Tickets.Service;

public interface ITicketService : ITransientService
{
    Task<Response<IEnumerable<TicketDto>>> GetAllAsync();
    Task<Response<TicketDto>> GetByIdAsync(string code);
    Task<Response<TicketDto>> CreateAsync(TicketRequest request);
}