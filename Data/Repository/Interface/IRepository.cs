using System.Linq.Expressions;

namespace ZingCRM_Demo.Data.Repository.Interface
{
    public interface IRepository<T> where T : class
    {
        Task<T> GetAsync(Expression<Func<T, object>> orderBy = null, bool ascending = true, Expression<Func<T, bool>> filter = null, string includeProperties = null, bool isTracked = false);
        Task<List<T>> GetAllAsync(Expression<Func<T, object>> orderBy = null, bool ascending = true, Expression<Func<T, bool>> filter = null, Expression<Func<T, object>> selector = null, string includeProperties = null, int pageSize = 0, int pageNumber = 1, bool isTracked = false);
        Task<int> GetTotalCountAsync(Expression<Func<T, bool>> filter = null, Expression<Func<T, object>> selector = null);
        Task CreateAsync(T entity);
        Task RemoveAsync(T entity);
        Task RemoveRangeAsync(IEnumerable<T> entity);
    }
}
