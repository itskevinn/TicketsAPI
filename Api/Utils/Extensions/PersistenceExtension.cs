using System.Data;
using System.Data.SqlClient;
using Domain.Ports;
using Infrastructure.Persistence.Factory;
using Infrastructure.Persistence.Repositories;

namespace TicketsWebServices.Utils.Extensions;

public static class PersistenceExtensions
{
    public static IServiceCollection AddPersistence(this IServiceCollection svc, IConfiguration config)
    {
        svc.AddScoped(typeof(IConnectionFactory), typeof(ConnectionFactory));

        svc.AddTransient(typeof(IAttachmentRepository), typeof(AttachmentRepository));
        svc.AddTransient(typeof(ITicketDetailRepository), typeof(TicketDetailRepository));
        svc.AddTransient(typeof(ITicketRepository), typeof(TicketRepository));
        svc.AddTransient(typeof(ITicketStatusRepository), typeof(TicketStatusRepository));
        svc.AddTransient<IDbConnection>(_ => new SqlConnection(config.GetConnectionString("local")));

        return svc;
    }
}