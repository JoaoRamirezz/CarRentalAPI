namespace Core.Shared;

public interface IRepository<T>
    where T : class
{
    public IQueryable<T> GetAll();

    public Task<T> GetById(int id);

    public Task<T> Add(T entity);

    public Task<T> Update(T entity);

    public Task<T> Delete(int id);

    public Task SaveChangesAsync();
}