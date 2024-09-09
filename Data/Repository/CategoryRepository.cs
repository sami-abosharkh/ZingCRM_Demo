using Microsoft.EntityFrameworkCore;
using ZingCRM_Demo.Models;
using ZingCRM_Demo.Data.Repository.Interface;

namespace ZingCRM_Demo.Data.Repository
{
    public class CategoryRepository(IDbContextFactory<ApplicationDbContext> contextFactory) : Repository<Category>(contextFactory), ICategoryRepository
    {
        private IDbContextFactory<ApplicationDbContext> _contextFactory = contextFactory;

        public async Task UpdateAsync(Category entity)
        {
            using var context = _contextFactory.CreateDbContext();
            context.Categories.Update(entity);
            await context.SaveChangesAsync();
        }
    }
}
