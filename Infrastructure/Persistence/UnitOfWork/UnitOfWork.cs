using Infrastructure.Persistence.Context;
using Infrastructure.Persistence.Factory;
using Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.UnitOfWork;

public sealed class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly IConnectionFactory _connectionFactory;
    private readonly TicketsContext _context;

    public UnitOfWork(IConnectionFactory connectionFactory, TicketsContext context)
    {
        _connectionFactory = connectionFactory ?? throw new ArgumentNullException(nameof(connectionFactory));
        _context = context;
    }

    private TicketRepository? _ticketRepository;
    private TicketDetailRepository? _ticketDetailRepository;
    private UserRepository? _userRepository;
    private MenuItemRepository? _menuItemRepository;
    private MenuItemRoleRepository? _menuItemRoleRepository;

    private UserRoleRepository? _userRoleRepository;
    private RoleRepository? _roleRepository;

    public TicketRepository TicketRepository
    {
        get
        {
            if (_connectionFactory.Connection == null) return null!;
            return _ticketRepository ??= new TicketRepository(_context, _connectionFactory.Connection);
        }
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

    public DbContext GetDbContext()
    {
        return _context;
    }

    private bool _disposed;

    private void Dispose(bool disposing)
    {
        if (!_disposed && disposing)
        {
            _context.Dispose();
        }

        _disposed = true;
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
}