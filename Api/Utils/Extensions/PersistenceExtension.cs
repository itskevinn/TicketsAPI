using System.Data;
using System.Data.SqlClient;
using Domain.Ports;
using Infrastructure.Persistence.Base;
using Infrastructure.Persistence.Factory;
using Infrastructure.Persistence.UnitOfWork;

namespace TicketsWebServices.Utils.Extensions;

public static class PersistenceExtensions
{
    public static IServiceCollection AddPersistence(this IServiceCollection svc, IConfiguration config)
    {
        svc.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        svc.AddTransient(typeof(IUnitOfWork), typeof(UnitOfWork));
        svc.AddSingleton(typeof(IConnectionFactory), typeof(ConnectionFactory));
        svc.AddTransient<IDbConnection>(_ => new SqlConnection(config.GetConnectionString("DefaultConnection")));
        return svc;
    }
}