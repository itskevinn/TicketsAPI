using System.Data;
using Dapper;
using Domain.Entity;
using Domain.Ports;
using Infrastructure.Persistence.Context;
using Infrastructure.Persistence.Repositories.Base;

namespace Infrastructure.Persistence.Repositories;

public class TicketRepository : GenericRepository<Ticket>, ITicketRepository
{
    private readonly IDbConnection _dbConnection;

    public TicketRepository(TicketsContext context, IDbConnection dbConnection) : base(context)
    {
        _dbConnection = dbConnection;
    }

    public async Task<Ticket> FindByCodeAsync(int code)
    {
        var sql = $"SELECT * FROM \"Ticket\" WHERE \"Code\" = '{code}'";
        return await _dbConnection.QueryFirstAsync<Ticket>(sql);
    }
}