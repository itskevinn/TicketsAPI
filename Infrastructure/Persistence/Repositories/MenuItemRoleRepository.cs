using Domain.Entity;
using Domain.Ports;
using Infrastructure.Persistence.Base;
using Infrastructure.Persistence.Context;

namespace Infrastructure.Persistence.Repositories;

public class MenuItemRoleRepository : GenericRepository<MenuItemRole>, IMenuItemRoleRepository
{
    public MenuItemRoleRepository(TicketsContext context) : base(context)
    {
    }
}