using Microsoft.EntityFrameworkCore;

namespace Core.Shared
{
    public abstract class BaseRepository<T, TDbContext> : IRepository<T>
        where T : class
        where TDbContext : DbContext
    {
        protected readonly TDbContext _context;

        public BaseRepository(TDbContext context)
        {
            _context = context;
        }

        public virtual IQueryable<T> GetAll()
        {
            return _context.Set<T>();
        }

        public virtual async Task<T> GetById(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public virtual Task<T> Add(T entity)
        {
            _context.Set<T>().Add(entity);
            return Task.FromResult(entity);
        }

        public virtual Task<T> Update(T entity)
        {
            _context.Set<T>().Update(entity);
            return Task.FromResult(entity);
        }

        public virtual Task<T> Delete(int id)
        {
            var entity = _context.Set<T>().Find(id);
            _context.Set<T>().Remove(entity);
            return Task.FromResult(entity);
        }

        public Task SaveChangesAsync()
        {
            return _context.SaveChangesAsync();
        }
    }
}