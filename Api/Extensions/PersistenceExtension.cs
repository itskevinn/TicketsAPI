using System.Data;
using System.Data.SqlClient;
using Domain.Ports;
using Infrastructure.Persistence.Base;

namespace TicketsWebServices.Extensions;

public static class PersistenceExtensions
{
    public static IServiceCollection AddPersistence(this IServiceCollection svc, IConfiguration config)
    {
        svc.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        svc.AddTransient<IDbConnection>(_ => new SqlConnection(config.GetConnectionString("DefaultConnection")));
        return svc;
    }
}