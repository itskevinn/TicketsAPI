using System.Data;
using Dapper;
using Domain.Entity;
using Domain.Ports;
using Infrastructure.Persistence.Context;
using Infrastructure.Persistence.Repositories.Base;
using Infrastructure.Persistence.UnitOfWork;

namespace Infrastructure.Persistence.Repositories;

public class TicketRepository : GenericRepository<Ticket>, ITicketRepository
{
    private readonly IDbConnection _dbConnection;

    public TicketRepository(TicketsContext context, IDbConnection dbConnection, IUnitOfWork unitOfWork) : base(context,
        unitOfWork)
    {
        _dbConnection = dbConnection;
    }

    public Ticket? FindByCode(int code)
    {
        try
        {
            return FindBy(t => t.Code == code);
        }
        finally
        {
            _dbConnection.Close();
        }
    }

    public async Task UpdateState(string newState, int code)
    {
        try
        {
            var sql = $"UPDATE \"Ticket\" SET \"State\" = '{newState}' WHERE \"Code\" = '{code}'";
            await _dbConnection.ExecuteAsync(sql);
        }
        finally
        {
            _dbConnection.Close();
        }
    }
}