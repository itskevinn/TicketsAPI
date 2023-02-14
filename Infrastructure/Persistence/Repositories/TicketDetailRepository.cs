using Dapper;
using Domain.Entity;
using Domain.Ports;
using Infrastructure.Persistence.Context;
using Infrastructure.Persistence.Exceptions;
using Infrastructure.Persistence.Factory;
using Infrastructure.Persistence.Repositories.Base;

namespace Infrastructure.Persistence.Repositories;

public class TicketDetailRepository : GenericRepository<TicketDetail>, ITicketDetailRepository
{
    private readonly IConnectionFactory _connectionFactory;

    public TicketDetailRepository(TicketsContext context, IConnectionFactory connectionFactory)
        : base(context)
    {
        _connectionFactory = connectionFactory;
    }

    public async Task<IEnumerable<TicketDetail>> GetTicketDetailsByTicketIdAsync(Guid ticketId)
    {
        var conn = _connectionFactory.Connection ??
                   throw new DatabaseUnavailableException(nameof(_connectionFactory.Connection));
        const char quotationMark = '\u0022';
        var sqlQuery = $"SELECT * FROM {quotationMark}TicketDetail{quotationMark} WHERE TicketId = {ticketId}";

        var ticketDetails = await conn.QueryAsync<TicketDetail>(sqlQuery);
        conn.Close();

        return ticketDetails.ToList();
    }

    public async Task<IEnumerable<TicketDetail>> GetTicketDetailsByTicketCodeAsync(int ticketCode)
    {
        var conn = _connectionFactory.Connection ??
                   throw new DatabaseUnavailableException(nameof(_connectionFactory.Connection));
        const char quotationMark = '\u0022';
        var sqlQuery =
            $"SELECT * FROM {quotationMark}TicketDetail{quotationMark} td INNER JOIN {quotationMark}Ticket{quotationMark} t ON t.{quotationMark}Id{quotationMark} = td.{quotationMark}TicketId{quotationMark} WHERE t.{quotationMark}Code{quotationMark} = {ticketCode} ";
        var query = await conn.QueryAsync<dynamic>(sqlQuery);
        var ticketDetails = query.Select(td => new TicketDetail
        {
            Id = new Guid(td.Id),
            Attachments = td.Attachments,
            Message = td.Message,
            CreatedBy = td.CreatedBy,
            CreatedOn = td.CreatedOn,
            TicketCode = (int)td.TicketCode,
            TicketId = new Guid(td.TicketId),
            LastModifiedBy = td.LastModifiedBy,
            LastModifiedOn = td.LastModifiedOn
        });
        var enumerable = ticketDetails.ToList();

        conn.Close();

        return enumerable.ToList();
    }

}