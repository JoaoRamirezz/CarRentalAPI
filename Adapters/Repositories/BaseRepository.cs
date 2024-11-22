using Adapters.Models;
using Core.Shared;

namespace Adapters.Repositories
{
    public abstract class BaseRepository<T> : IRepository<T>
        where T : class
    {
        protected readonly CarRentalDbContext _context;

        public BaseRepository(CarRentalDbContext context)
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