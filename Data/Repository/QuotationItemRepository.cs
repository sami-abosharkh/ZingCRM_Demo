using Microsoft.EntityFrameworkCore;
using ZingCRM_Demo.Models;
using ZingCRM_Demo.Data.Repository.Interface;

namespace ZingCRM_Demo.Data.Repository
{
    public class QuotationItemRepository(IDbContextFactory<ApplicationDbContext> contextFactory) : Repository<QuotationItem>(contextFactory), IQuotationItemRepository
    {
        private IDbContextFactory<ApplicationDbContext> _contextFactory = contextFactory;

        public async Task UpdateAsync(QuotationItem entity)
        {
            using var context = _contextFactory.CreateDbContext();
            context.QuotationItems.Update(entity);
            await context.SaveChangesAsync();
        }
    }
}
