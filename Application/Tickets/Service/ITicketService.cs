using Application.Tickets.Http.Dto;
using Application.Tickets.Http.Request;

namespace Application.Tickets.Service;

public interface ITicketService
{
    Task<IEnumerable<TicketDto>> GetAllAsync();
    Task<TicketDto> GetByIdAsync(string code);
    Task<TicketDto> CreateAsync(TicketRequest request);
}