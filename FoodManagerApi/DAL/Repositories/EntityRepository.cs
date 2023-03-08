using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories;
public class EntityRepository<T> : IEntityRepository<T> where T : class
{
    private readonly FoodManagerDbContext _dbContext;
    private readonly DbSet<T> _dbSet;
    public EntityRepository(FoodManagerDbContext dbContext)
    {
        _dbContext = dbContext;
        _dbSet = _dbContext.Set<T>();
    }

    public async Task<T> Create(T entity)
    {
        await _dbSet.AddAsync(entity);
        await _dbContext.SaveChangesAsync();
        return await Task.FromResult(entity);
    }

    public async Task Delete(T entity)
    {
        _dbContext.Entry(entity).State = EntityState.Deleted;

        await _dbContext.SaveChangesAsync();
    }

    public async Task<IEnumerable<T>> GetAll()
    {
        return await _dbSet.ToListAsync();
    }

    public async Task<T> GetById(Guid entityId)
    {
        return await _dbSet.FindAsync(entityId).AsTask();
    }

    public async Task<T> Update(T entity)
    {
        _dbContext.Entry(entity).State = EntityState.Modified;

        await _dbContext.SaveChangesAsync();
        return entity;
    }
}
