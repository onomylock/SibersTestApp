using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Infrastructure.Repository
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private DbContext Context;

        protected BaseRepository(DbContext context) => Context = context;

        public IQueryable<T> FindAll() => Context.Set<T>().AsNoTracking();

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression) => Context.Set<T>()
                .Where(expression).AsNoTracking();

        public void Create(T entity) => Context.Set<T>().Add(entity);

        public void Update(T entity) => Context.Set<T>().Update(entity);

        public void Delete(T entity) => Context.Set<T>().Remove(entity);

        public async Task CreateRangeAsync(IEnumerable<T> entities) => await Context.Set<T>().AddRangeAsync(entities);

        public void RemoveRangeAsync(IEnumerable<T> entities) => Context.Set<T>().RemoveRange(entities);
    }
}
