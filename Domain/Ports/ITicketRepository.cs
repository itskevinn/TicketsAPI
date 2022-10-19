using Domain.Entity;

namespace Domain.Ports;

public interface ITicketRepository : IGenericRepository<Ticket>
{
    Task<Ticket> FindByCodeAsync(string code);
}