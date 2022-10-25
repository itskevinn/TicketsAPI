using System.Linq.Expressions;
using Domain.Entity.Base;
using Domain.Ports;
using Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories.Base;

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
        await Context.SaveChangesAsync();
        return entity;
    }

    public virtual void Update(TEntity entity)
    {
        _dbSet.Attach(entity);
        Context.Entry(entity).State = EntityState.Modified;
        Context.SaveChanges();
    }

    public virtual async Task DeleteAsync(TEntity entity)
    {
        var entityToDelete = await _dbSet.FindAsync(entity);
        if (entityToDelete != null) Delete(entityToDelete);
        await Context.SaveChangesAsync();
    }

    public virtual void Delete(TEntity entity)
    {
        if (Context.Entry(entity).State == EntityState.Detached)
        {
            _dbSet.Attach(entity);
        }

        _dbSet.Remove(entity);
        Context.SaveChanges();
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
        await Context.SaveChangesAsync();
    }

    public virtual async Task<TEntity> FindByAsync(Expression<Func<TEntity, bool>>? filter = null,
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
        return result ?? null!;
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