using Domain.Entity;
using Domain.Ports;
using Infrastructure.Persistence.Context;
using Infrastructure.Persistence.Repositories.Base;

namespace Infrastructure.Persistence.Repositories;

public class MenuItemRoleRepository : GenericRepository<MenuItemRole>, IMenuItemRoleRepository
{
    public MenuItemRoleRepository(TicketsContext context) : base(context)
    {
    }
}