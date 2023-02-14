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
        svc.AddTransient(typeof(IMenuItemRepository), typeof(MenuItemRepository));
        svc.AddTransient(typeof(IMenuItemRoleRepository), typeof(MenuItemRoleRepository));
        svc.AddTransient(typeof(IRoleRepository), typeof(RoleRepository));
        svc.AddTransient(typeof(ITicketDetailRepository), typeof(TicketDetailRepository));
        svc.AddTransient(typeof(ITicketRepository), typeof(TicketRepository));
        svc.AddTransient(typeof(ITicketStatusRepository), typeof(TicketStatusRepository));
        svc.AddTransient(typeof(IUserRepository), typeof(UserRepository));
        svc.AddTransient(typeof(IUserRoleRepository), typeof(UserRoleRepository));        svc.AddTransient<IDbConnection>((_) => new SqlConnection(config.GetConnectionString("local")));
        svc.AddTransient<IDbConnection>((_) => new SqlConnection(config.GetConnectionString("local")));

        return svc;
    }
}