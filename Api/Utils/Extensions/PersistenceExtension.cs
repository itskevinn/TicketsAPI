using Infrastructure.Persistence.Factory;
using Infrastructure.Persistence.UnitOfWork;

namespace TicketsWebServices.Utils.Extensions;

public static class PersistenceExtensions
{
    public static IServiceCollection AddPersistence(this IServiceCollection svc, IConfiguration config)
    {
        svc.AddTransient(typeof(IUnitOfWork), typeof(UnitOfWork));
        svc.AddSingleton(typeof(IConnectionFactory), typeof(ConnectionFactory));
        return svc;
    }
}