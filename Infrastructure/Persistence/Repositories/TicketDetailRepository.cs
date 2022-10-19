using Dapper;
using Domain.Entity;
using Domain.Ports;
using Infrastructure.Persistence.Base;
using Infrastructure.Persistence.Context;
using Infrastructure.Persistence.Factory;

namespace Infrastructure.Persistence.Repositories;

public class TicketDetailRepository : GenericRepository<TicketDetail>, ITicketDetailRepository
{
    private readonly IConnectionFactory _connectionFactory;

    public TicketDetailRepository(TicketsContext context, IConnectionFactory connectionFactory) : base(context)
    {
        _connectionFactory = connectionFactory;
    }
    public async  Task<IEnumerable<TicketDetail>> GetTicketDetailByTicketIdAsync(Guid ticketId,
        CancellationToken cancellationToken = default)
    {
        using var conn = _connectionFactory.Connection ??
                         throw new NullReferenceException(nameof(_connectionFactory.Connection));
        {
            var sqlQuery = $"SELECT * FROM TicketDetail WHERE TicketId = {ticketId}";

            var ticketDetails = await conn.QueryAsync<TicketDetail>(sqlQuery);
            conn.Close();

            return ticketDetails.ToList();
        }
    }
}