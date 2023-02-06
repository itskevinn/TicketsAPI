using Domain.Entity;

namespace Domain.Ports;

public interface ITicketRepository : IGenericRepository<Ticket>
{
    ///<summary>
    /// Finds a ticket by a given code
    /// <param name="code">The given code</param>
    /// <returns><see cref="TicketStatus"/></returns>
    /// </summary>
    Ticket? FindByCode(int code);

    ///<summary>
    /// Updates the ticket status
    /// <param name="newStatusId">The new status identifier</param>
    /// <param name="code">The code of the ticket to update</param>
    /// <returns><see cref="TicketStatus"/></returns>
    /// </summary>
    Task UpdateState(string newStatusId, int code);
}