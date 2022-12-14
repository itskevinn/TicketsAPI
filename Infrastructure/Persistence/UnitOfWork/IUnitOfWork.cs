using Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.UnitOfWork;

public interface IUnitOfWork
{
    TicketRepository TicketRepository { get; }
    TicketDetailRepository TicketDetailRepository { get; }
    UserRepository UserRepository { get; }

    UserRoleRepository UserRoleRepository { get; }
    RoleRepository RoleRepository { get; }
    MenuItemRepository MenuItemRepository { get; }
    MenuItemRoleRepository MenuItemRoleRepository { get; }

    void Save();
    Task SaveChangesAsync();
    DbContext GetDbContext();
    Task CommitAsync();
    void Commit();
    void ClearTracking();
}