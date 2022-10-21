using Domain.Entity;

namespace Domain.Ports;

public interface ITicketDetailRepository : IGenericRepository<TicketDetail>
{
    Task<IEnumerable<TicketDetail>> GetTicketDetailByTicketIdAsync(Guid ticketId,
        CancellationToken cancellationToken = default);
}