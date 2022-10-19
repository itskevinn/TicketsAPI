using Infrastructure.Persistence.Repositories;

namespace Infrastructure.Persistence.UnitOfWork;

public interface IUnitOfWork
{
    public TicketRepository TicketRepository { get; }
    public TicketDetailRepository TicketDetailRepository { get; }
    public UserRepository UserRepository { get; }

    public UserRoleRepository UserRoleRepository { get; }
    public RoleRepository RoleRepository { get; }
    public MenuItemRepository MenuItemRepository { get; }
    public MenuItemRoleRepository MenuItemRoleRepository { get; }

    public void Save();

    protected void Dispose(bool disposing);

    public void Dispose();
}