using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Threading.Tasks;
using ZingCRM_Demo.Data.Repository.Interface;
using ZingCRM_Demo.Models;

namespace ZingCRM_Demo.Data.Repository
{
    public class ExplicitLoadingRepository(IDbContextFactory<ApplicationDbContext> contextFactory) : IExplicitLoadingRepository
    {
        private readonly IDbContextFactory<ApplicationDbContext> _contextFactory = contextFactory;

        public async Task LoadCollectionAsync<TEntity, TProperty>(
            TEntity entity,
            Expression<Func<TEntity, IEnumerable<TProperty>>> navigationProperty)
            where TEntity : class
            where TProperty : class
        {
            ArgumentNullException.ThrowIfNull(entity);
            ArgumentNullException.ThrowIfNull(navigationProperty);

            try
            {
                using var context = _contextFactory.CreateDbContext();
                context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;

                if (navigationProperty == null) return;

                // Load the collection explicitly
                await context.Entry(entity)
                             .Collection(navigationProperty)
                             .LoadAsync();
            }
            catch (DbUpdateException dbEx)
            {
                // Handle specific database update exceptions
                Debug.WriteLine(dbEx);
                throw;
            }
            catch (Exception ex)
            {
                // Log other exceptions
                Debug.WriteLine(ex);
                throw;
            }
        }

        public async Task LoadReferenceAsync<TEntity, TProperty>(
            TEntity entity,
            Expression<Func<TEntity, TProperty>> navigationProperty)
            where TEntity : class
            where TProperty : class
        {
            ArgumentNullException.ThrowIfNull(entity);
            ArgumentNullException.ThrowIfNull(navigationProperty);

            try
            {
                using var context = _contextFactory.CreateDbContext();
                context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;

                // Load the reference explicitly
                await context.Entry(entity)
                             .Reference(navigationProperty)
                             .LoadAsync();

            }
            catch (DbUpdateException dbEx)
            {
                // Handle specific database update exceptions
                Debug.WriteLine(dbEx);
                throw;
            }
            catch (Exception ex)
            {
                // Log other exceptions
                Debug.WriteLine(ex);
                throw;
            }
        }
    }
}
