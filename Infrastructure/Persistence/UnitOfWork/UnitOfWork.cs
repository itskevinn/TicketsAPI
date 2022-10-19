using Infrastructure.Persistence.Context;
using Infrastructure.Persistence.Factory;
using Infrastructure.Persistence.Repositories;

namespace Infrastructure.Persistence.UnitOfWork;

public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly IConnectionFactory _connectionFactory;

    public UnitOfWork(IConnectionFactory connectionFactory)
    {
        _connectionFactory = connectionFactory ?? throw new ArgumentNullException(nameof(connectionFactory));
    }

    private readonly TicketsContext _context = new();
    private TicketRepository? _ticketRepository;
    private TicketDetailRepository? _ticketDetailRepository;
    private UserRepository? _userRepository;
    private MenuItemRepository? _menuItemRepository;
    private MenuItemRoleRepository? _menuItemRoleRepository;

    private UserRoleRepository? _userRoleRepository;
    private RoleRepository? _roleRepository;

    public TicketRepository TicketRepository
    {
        get { return _ticketRepository ??= new TicketRepository(_context, _connectionFactory.Connection); }
    }

    public UserRoleRepository UserRoleRepository
    {
        get { return _userRoleRepository ??= new UserRoleRepository(_context); }
    }

    public RoleRepository RoleRepository
    {
        get { return _roleRepository ??= new RoleRepository(_context); }
    }

    public TicketDetailRepository TicketDetailRepository
    {
        get { return _ticketDetailRepository ??= new TicketDetailRepository(_context, _connectionFactory); }
    }

    public MenuItemRepository MenuItemRepository
    {
        get { return _menuItemRepository ??= new MenuItemRepository(_context); }
    }

    public MenuItemRoleRepository MenuItemRoleRepository
    {
        get { return _menuItemRoleRepository ??= new MenuItemRoleRepository(_context); }
    }

    public UserRepository UserRepository
    {
        get { return _userRepository ??= new UserRepository(_context); }
    }

    public void Save()
    {
        _context.SaveChanges();
    }

    void IUnitOfWork.Dispose(bool disposing)
    {
        Dispose(disposing);
    }

    private bool _disposed;

    protected virtual void Dispose(bool disposing)
    {
        if (!_disposed)
        {
            if (disposing)
            {
                _context.Dispose();
            }
        }

        _disposed = true;
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
}