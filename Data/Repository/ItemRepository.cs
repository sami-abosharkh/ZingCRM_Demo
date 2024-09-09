using Microsoft.EntityFrameworkCore;
using ZingCRM_Demo.Models;
using ZingCRM_Demo.Data.Repository.Interface;

namespace ZingCRM_Demo.Data.Repository
{
    public class ItemRepository : Repository<ItemM>, IItemRepository
    {
        private IDbContextFactory<ApplicationDbContext> _contextFactory;
        public ItemRepository(IDbContextFactory<ApplicationDbContext> contextFactory) : base(contextFactory)
        {
            _contextFactory = contextFactory;
        }
        public async Task UpdateAsync(ItemM entity)
        {
            using (var context = _contextFactory.CreateDbContext())
            {
                context.Items.Update(entity);
                await context.SaveChangesAsync();
            }
        }
    }
}
