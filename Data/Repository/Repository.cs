using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Linq.Expressions;
using ZingCRM_Demo.Data.Repository.Interface;
using ZingCRM_Demo.Models;

namespace ZingCRM_Demo.Data.Repository
{
    public class Repository<T>(IDbContextFactory<ApplicationDbContext> contextFactory) : IRepository<T> where T : class
    {
        private readonly IDbContextFactory<ApplicationDbContext> _contextFactory = contextFactory;
        private static readonly char[] separator = [','];

        public async Task CreateAsync(T entity)
        {
            try
            {
                using var context = _contextFactory.CreateDbContext();
                await context.Set<T>().AddAsync(entity);
                await context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<List<T>> GetAllAsync(Expression<Func<T, object>> orderBy = null, bool ascending = true, Expression<Func<T, bool>> filter = null, Expression<Func<T, object>> selector = null, string includeProperties = null, int pageSize = 0, int pageNumber = 1)
        {
            try
            {
                using var context = _contextFactory.CreateDbContext();
                context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
                IQueryable<T> query = context.Set<T>();

                if (filter != null)
                {
                    query = query.Where(filter);
                }
                if (pageSize > 0)
                {
                    if (pageSize > 100)
                    {
                        pageSize = 100;
                    }
                    query = query.Skip(pageSize * (pageNumber - 1)).Take(pageSize);
                }
                if (orderBy != null)
                {
                    // Apply ordering based on the specified criteria
                    query = ascending ? query.OrderBy(orderBy) : query.OrderByDescending(orderBy);
                }
                if (selector != null)
                {
                    // Selects the first entity from each group
                    query = query.GroupBy(selector).Select(g => g.First());
                }
                if (!string.IsNullOrEmpty(includeProperties))
                {
                    foreach (var includeProp in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                    {
                        query = query.Include(includeProp);
                    }
                }
                return await query.ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<T> GetAsync(Expression<Func<T, object>> orderBy = null, bool ascending = true, Expression<Func<T, bool>> filter = null, string includeProperties = null)
        {
            try
            {
                using var context = _contextFactory.CreateDbContext();
                context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
                IQueryable<T> query = context.Set<T>();

                if (orderBy != null)
                {
                    query = ascending ? query.OrderBy(orderBy) : query.OrderByDescending(orderBy);
                }

                if (filter != null)
                {
                    query = query.Where(filter);
                }

                if (!string.IsNullOrEmpty(includeProperties))
                {
                    foreach (var includeProp in includeProperties.Split(separator, StringSplitOptions.RemoveEmptyEntries))
                    {
                        query = query.Include(includeProp);
                    }
                }

                return await query.FirstOrDefaultAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<int> GetTotalCountAsync(Expression<Func<T, bool>> filter = null, Expression<Func<T, object>> selector = null)
        {
            using var context = _contextFactory.CreateDbContext();
            IQueryable<T> query = context.Set<T>();

            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (selector != null)
            {
                return await query.Select(selector).Distinct().CountAsync();
            }

            return await query.CountAsync();  // Return the count of distinct items
        }

        public async Task RemoveAsync(T entity)
        {
            using var context = _contextFactory.CreateDbContext();
            context.Set<T>().Remove(entity);
            await context.SaveChangesAsync();
        }

        public async Task RemoveRange(IEnumerable<T> entity)
        {
            using var context = _contextFactory.CreateDbContext();
            context.Set<T>().RemoveRange(entity);
            await context.SaveChangesAsync();
        }
    }
}
