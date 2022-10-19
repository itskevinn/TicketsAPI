using System.Linq.Expressions;
using Domain.Entity.Base;

namespace Domain.Ports;

public interface IGenericRepository<TEntity> where TEntity : DomainEntity 
{
    Task<TEntity> CreateAsync(TEntity entity);
    void Update(TEntity entity);
    Task DeleteAsync(object entity);
    void Delete(TEntity entity);
    Task<TEntity?> FindAsync(object? id);
    Task<bool> ExistsAsync(object id);
    Task CreateAllAsync(IEnumerable<TEntity> entities);

    Task<TEntity> Find(Expression<Func<TEntity, bool>>? filter = null,
        bool isTracking = false,
        string includeStringProperties = "");

    Task<IQueryable<TEntity>> GetAsync(
        Expression<Func<TEntity, bool>>? filter = null,
        Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null,
        bool isTracking = false,
        string includeStringProperties = "");
}