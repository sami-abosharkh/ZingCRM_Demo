using ZingCRM_Demo.Models;

namespace ZingCRM_Demo.Data.Repository.Interface
{
    public interface IPurchaseRequisitionRepository : IRepository<PurchaseRequisition>
    {
        Task UpdateAsync(PurchaseRequisition entity);
    }
}
