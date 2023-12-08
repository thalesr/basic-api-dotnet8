using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace RestaurantManager.Database.Repositories.Definitions
{
    public interface IGenericRepository<T> where T : class
    {
        Task<List<T>> GetAll(Expression<Func<T, bool>> expression = null,
                            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                            Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null,
                            int limitRows = 0);

        Task<T> Get(Expression<Func<T, bool>> expression, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null);
        Task<int> Count(Expression<Func<T, bool>> expression = null);
        Task Insert(T entity);
        Task InsertRange(IEnumerable<T> entities);
        Task Delete(int id);
        void DeleteRange(IEnumerable<T> entities);
        void Update(T entity);
        Task Save();
    }
}
