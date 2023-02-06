using Domain.Entity;

namespace Domain.Ports;

public interface ITicketDetailRepository : IGenericRepository<TicketDetail>
{
    Task<IEnumerable<TicketDetail>> GetTicketDetailsByTicketIdAsync(Guid ticketId);
    Task<IEnumerable<TicketDetail>> GetTicketDetailsByTicketCodeAsync(int ticketCode);
}