using Domain.Entity;

namespace Domain.Ports;

public interface ITicketRepository : IGenericRepository<Ticket>
{
    Ticket? FindByCode(int code);
    Task UpdateState(string newState, int code);
}