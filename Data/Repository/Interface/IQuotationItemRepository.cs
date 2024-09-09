using ZingCRM_Demo.Models;

namespace ZingCRM_Demo.Data.Repository.Interface
{
    public interface IQuotationItemRepository : IRepository<QuotationItem>
    {
        Task UpdateAsync(QuotationItem entity);
    }
}
