using System.Linq.Expressions;

namespace ZingCRM_Demo.Data.Repository.Interface
{
    public interface IRepository<T> where T : class
    {
        Task<int> GetTotalCountAsync(Expression<Func<T, bool>> filter = null, Expression<Func<T, object>> selector = null);
        Task<List<T>> GetAllAsync(Expression<Func<T, object>> orderBy = null, bool ascending = true, Expression<Func<T, bool>> filter = null, Expression<Func<T, object>> selector = null, string includeProperties = null, int pageSize = 0, int pageNumber = 1);
        Task<T> GetAsync(Expression<Func<T, object>> orderBy = null, bool ascending = true, Expression<Func<T, bool>> filter = null, string includeProperties = null);
        Task CreateAsync(T entity);
        Task RemoveAsync(T entity);
        Task RemoveRange(IEnumerable<T> entity);
    }
}
