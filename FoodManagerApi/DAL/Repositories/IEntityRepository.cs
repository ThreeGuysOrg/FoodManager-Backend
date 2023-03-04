namespace DAL.Repositories;
public interface IEntityRepository<T> where T : class
{
    Task<T> Create(T entity);
    Task<T> Update(T entity);
    Task Delete(T entity);
    Task<T> GetById(Guid entityId);
    Task<IEnumerable<T>> GetAll();
}
