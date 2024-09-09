using Microsoft.EntityFrameworkCore;
using ZingCRM_Demo.Models;
using ZingCRM_Demo.Data.Repository.Interface;

namespace ZingCRM_Demo.Data.Repository
{
    public class ItemRepository(IDbContextFactory<ApplicationDbContext> contextFactory) : Repository<Item>(contextFactory), IItemRepository
    {
        private IDbContextFactory<ApplicationDbContext> _contextFactory = contextFactory;

        public async Task UpdateAsync(Item entity)
        {
            using var context = _contextFactory.CreateDbContext();
            context.Items.Update(entity);
            await context.SaveChangesAsync();
        }
    }
}
