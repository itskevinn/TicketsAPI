using Domain.Entity;
using Domain.Ports;
using Infrastructure.Persistence.Context;
using Infrastructure.Persistence.Repositories.Base;

namespace Infrastructure.Persistence.Repositories;

public class MenuItemRepository : GenericRepository<MenuItem>, IMenuItemRepository
{
    public MenuItemRepository(TicketsContext context) : base(context)
    {
    }
}