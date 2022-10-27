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
            return _ticketRepository ??= new TicketRepository(_context, _connectionFactory.Connection, this);
        }
    }

    public UserRoleRepository UserRoleRepository
    {
        get { return _userRoleRepository ??= new UserRoleRepository(_context, this); }
    }

    public RoleRepository RoleRepository
    {
        get { return _roleRepository ??= new RoleRepository(_context, this); }
    }

    public TicketDetailRepository TicketDetailRepository
    {
        get { return _ticketDetailRepository ??= new TicketDetailRepository(_context, _connectionFactory, this); }
    }

    public MenuItemRepository MenuItemRepository
    {
        get { return _menuItemRepository ??= new MenuItemRepository(_context, this); }
    }

    public MenuItemRoleRepository MenuItemRoleRepository
    {
        get { return _menuItemRoleRepository ??= new MenuItemRoleRepository(_context, this); }
    }

    public UserRepository UserRepository
    {
        get { return _userRepository ??= new UserRepository(_context, this); }
    }

    public void Save()
    {
        _context.SaveChanges();
    }

    public async Task SaveChangesAsync()
    {
        await CommitAsync();
    }

    public void ClearTracking()
    {
        _context.ChangeTracker.Clear();
    }

    public async Task CommitAsync()
    {
        CheckEntityState();
        await _context.SaveChangesAsync().ConfigureAwait(false);
    }

    public void Commit()
    {
        CheckEntityState();
        _context.SaveChanges();
    }

    private void CheckEntityState()
    {
        _context.ChangeTracker.DetectChanges();

        foreach (var entry in _context.ChangeTracker.Entries())
        {
            switch (entry.State)
            {
                case EntityState.Added:
                    entry.Property("CreatedOn").CurrentValue = DateTime.UtcNow;
                    entry.Property("Status").CurrentValue = true;
                    break;
                case EntityState.Modified:
                    entry.Property("LastModifiedOn").CurrentValue = DateTime.UtcNow;
                    entry.Property("Status").CurrentValue = true;
                    break;
                case EntityState.Deleted:
                    entry.Property("Status").CurrentValue = false;
                    break;
            }
        }
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

    ~UnitOfWork()
    {
        _context.Dispose();
        _connectionFactory.Connection?.Dispose();
    }
}