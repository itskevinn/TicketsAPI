using System.Linq.Expressions;
using Domain.Entity.Base;
using Domain.Ports;
using Infrastructure.Persistence.Context;
using Infrastructure.Persistence.UnitOfWork;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories.Base;

public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : DomainEntity
{
    private readonly TicketsContext _context;
    private readonly IUnitOfWork _unitOfWork;
    private readonly DbSet<TEntity> _dbSet;

    protected GenericRepository(TicketsContext context, IUnitOfWork unitOfWork)
    {
        _context = context;
        _unitOfWork = unitOfWork;
        _dbSet = context.Set<TEntity>();
    }

    public virtual async Task<TEntity> CreateAsync(TEntity entity)
    {
        _ = entity ?? throw new ArgumentNullException(nameof(entity), $"{nameof(entity)} can not be null");
        await _dbSet.AddAsync(entity);
        await _unitOfWork.CommitAsync();
        return entity;
    }

    public virtual void Update(TEntity entity)
    {
        _ = entity ?? throw new ArgumentNullException(nameof(entity), $"{nameof(entity)} can not be null");
        _context.Entry(entity).State = EntityState.Modified;
        _dbSet.Update(entity);
        _unitOfWork.CommitAsync();
    }

    public virtual async Task DeleteAsync(TEntity entity)
    {
        _ = entity ?? throw new ArgumentNullException(nameof(entity), $"{nameof(entity)} can not be null");
        var entityToDelete = await _dbSet.FindAsync(entity);
        if (entityToDelete != null) Delete(entityToDelete);
        await _context.SaveChangesAsync();
    }

    public virtual void Delete(TEntity entity)
    {
        _ = entity ?? throw new ArgumentNullException(nameof(entity), $"{nameof(entity)} can not be null");
        if (_context.Entry(entity).State == EntityState.Detached)
        {
            _dbSet.Attach(entity);
        }

        _dbSet.Remove(entity);
        _context.SaveChangesAsync();
    }

    public virtual async Task<TEntity?> FindAsync(object? id)
    {
        return await _dbSet.FindAsync(id);
    }

    public virtual async Task<bool> ExistsAsync(object id)
    {
        return await _dbSet.FindAsync(id) != null;
    }

    public virtual async Task CreateAllAsync(IEnumerable<TEntity> entities)
    {
        _ = entities ?? throw new ArgumentNullException(nameof(entities), $"{nameof(entities)} can not be null");
        await _dbSet.AddRangeAsync(entities);
        await _context.SaveChangesAsync();
    }

    public virtual async Task<TEntity?> FindByAsync(Expression<Func<TEntity, bool>>? filter = null,
        bool isTracking = false,
        string includeStringProperties = "")
    {
        IQueryable<TEntity> query = _dbSet;

        if (filter != null)
        {
            query = query.Where(filter);
        }

        query = includeStringProperties.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
            .Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
        var result = await query.FirstOrDefaultAsync();
        return result ?? null;
    }

    public virtual TEntity? FindBy(Expression<Func<TEntity, bool>>? filter = null,
        bool isTracking = false,
        string includeStringProperties = "")
    {
        IQueryable<TEntity> query = _dbSet;

        if (filter != null)
        {
            query = query.Where(filter);
        }

        query = includeStringProperties.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
            .Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
        var result = query.FirstOrDefault();
        return result ?? null;
    }

    public virtual Task<IQueryable<TEntity>> GetAsync(Expression<Func<TEntity, bool>>? filter = null,
        Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null, bool isTracking = false,
        string includeStringProperties = "")
    {
        IQueryable<TEntity> query = _dbSet;

        if (filter != null)
        {
            query = query.Where(filter);
        }

        query = includeStringProperties.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
            .Aggregate(query, (current, includeProperty) => current.Include(includeProperty));

        return Task.FromResult(orderBy != null ? orderBy(query) : query);
    }
}