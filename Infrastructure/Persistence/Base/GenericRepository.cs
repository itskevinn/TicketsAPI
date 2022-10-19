using System.Linq.Expressions;
using Domain.Entity.Base;
using Domain.Ports;
using Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Base;

public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : DomainEntity
{
    protected readonly TicketsContext Context;
    private readonly DbSet<TEntity> _dbSet;

    public GenericRepository(TicketsContext context)
    {
        Context = context;
        _dbSet = context.Set<TEntity>();
    }

    public virtual async Task<TEntity> CreateAsync(TEntity entity)
    {
        await _dbSet.AddAsync(entity);
        return entity;
    }

    public virtual void Update(TEntity entityToUpdate)
    {
        _dbSet.Attach(entityToUpdate);
        Context.Entry(entityToUpdate).State = EntityState.Modified;
    }

    public virtual async Task DeleteAsync(object id)
    {
        var entityToDelete = await _dbSet.FindAsync(id);
        if (entityToDelete != null) Delete(entityToDelete);
    }

    public virtual void Delete(TEntity entityToDelete)
    {
        if (Context.Entry(entityToDelete).State == EntityState.Detached)
        {
            _dbSet.Attach(entityToDelete);
        }

        _dbSet.Remove(entityToDelete);
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
        await _dbSet.AddRangeAsync(entities);
    }

    public virtual Task<TEntity> Find(Expression<Func<TEntity, bool>>? filter = null, bool isTracking = false,
        string includeStringProperties = "")
    {
        IQueryable<TEntity> query = _dbSet;

        if (filter != null)
        {
            query = query.Where(filter);
        }

        query = includeStringProperties.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
            .Aggregate(query, (current, includeProperty) => current.Include(includeProperty));

        return Task.FromResult((query.FirstOrDefault() ?? null) ?? throw new NullReferenceException());
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