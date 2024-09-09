using Microsoft.EntityFrameworkCore;
using ZingCRM_Demo.Models;
using ZingCRM_Demo.Data.Repository.Interface;

namespace ZingCRM_Demo.Data.Repository
{
    public class PurchaseRequisitionRepository(IDbContextFactory<ApplicationDbContext> contextFactory) : Repository<PurchaseRequisition>(contextFactory), IPurchaseRequisitionRepository
    {
        private readonly IDbContextFactory<ApplicationDbContext> _contextFactory = contextFactory;

        public async Task UpdateAsync(PurchaseRequisition entity)
        {
            using var context = _contextFactory.CreateDbContext();
            context.PurchaseRequisitions.Update(entity);
            await context.SaveChangesAsync();
        }
    }
}
