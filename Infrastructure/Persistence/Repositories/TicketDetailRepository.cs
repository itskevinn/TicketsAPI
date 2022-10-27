using Dapper;
using Domain.Entity;
using Domain.Ports;
using Infrastructure.Persistence.Context;
using Infrastructure.Persistence.Exceptions;
using Infrastructure.Persistence.Factory;
using Infrastructure.Persistence.Repositories.Base;
using Infrastructure.Persistence.UnitOfWork;

namespace Infrastructure.Persistence.Repositories;

public class TicketDetailRepository : GenericRepository<TicketDetail>, ITicketDetailRepository
{
    private readonly IConnectionFactory _connectionFactory;

    public TicketDetailRepository(TicketsContext context, IConnectionFactory connectionFactory, IUnitOfWork unitOfWork) : base(context, unitOfWork)
    {
        _connectionFactory = connectionFactory;
    }

    public async Task<IEnumerable<TicketDetail>> GetTicketDetailByTicketIdAsync(Guid ticketId,
        CancellationToken cancellationToken = default)
    {
        var conn = _connectionFactory.Connection ??
                   throw new DatabaseUnavailableException(nameof(_connectionFactory.Connection));
        var sqlQuery = $"SELECT * FROM TicketDetail WHERE TicketId = {ticketId}";

        var ticketDetails = await conn.QueryAsync<TicketDetail>(sqlQuery);
        conn.Close();

        return ticketDetails.ToList();
    }
}