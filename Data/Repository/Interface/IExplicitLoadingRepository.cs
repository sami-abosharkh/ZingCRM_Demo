using System.Linq.Expressions;

namespace ZingCRM_Demo.Data.Repository.Interface
{
    public interface IExplicitLoadingRepository
    {
        Task LoadCollectionAsync<TEntity, TProperty>(
            TEntity entity,
            Expression<Func<TEntity, IEnumerable<TProperty>>> navigationProperty)
            where TEntity : class
            where TProperty : class;

        Task LoadReferenceAsync<TEntity, TProperty>(
            TEntity entity,
            Expression<Func<TEntity, TProperty>> navigationProperty)
            where TEntity : class
            where TProperty : class;
    }
}
