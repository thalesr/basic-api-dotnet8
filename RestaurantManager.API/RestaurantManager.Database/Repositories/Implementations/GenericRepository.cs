using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using RestaurantManager.Database.Repositories.Definitions;
using System.Linq.Expressions;
using RestaurantManager.Database.Context;

namespace RestaurantManager.Database.Repositories.Implementations
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {

        private readonly RestaurantManagerDbContext _context;
        private readonly DbSet<T> _db;

        public GenericRepository(RestaurantManagerDbContext context)
        {
            _context = context;
            _db = _context.Set<T>();
        }

        public async Task Delete(int id)
        {
            var entity = await _db.FindAsync(id);
            _db.Remove(entity);
        }

        public void DeleteRange(IEnumerable<T> entities)
        {
            _db.RemoveRange(entities);
        }

        public async Task<T> Get(Expression<Func<T, bool>> expression, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null)
        {
            IQueryable<T> query = _db;
            if (include != null)
            {
                query = include(query);
            }

            return await query.FirstOrDefaultAsync(expression);
        }

        public async Task<List<T>> GetAll(Expression<Func<T, bool>> expression = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null,
            int startIndex = 1,
            int size = 0)
        {
            IQueryable<T> query = _db;

            if (expression != null)
            {
                query = query.Where(expression);
            }

            if (include != null)
            {
                query = include(query);
            }

            if (orderBy != null)
            {
                query = orderBy(query);
            }

            if (startIndex > 0)
            {
                query = query.Skip(startIndex - 1);
            }

            if (size > 0)
            {
                query = query.Take(size);
            }

            return await query.ToListAsync();

        }

        public async Task<int> Count(Expression<Func<T, bool>> expression = null)
        {
            IQueryable<T> query = _db;

            if (expression != null)
            {
                query = query.Where(expression);
            }

            return await query.AsNoTracking().CountAsync();
        }

        public async Task Insert(T entity)
        {
            await _db.AddAsync(entity);
        }

        public async Task InsertRange(IEnumerable<T> entities)
        {
            await _db.AddRangeAsync(entities);
        }

        public void Update(T entity)
        {
            _db.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }

    }
}
