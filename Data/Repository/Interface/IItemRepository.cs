using ZingCRM_Demo.Models;

namespace ZingCRM_Demo.Data.Repository.Interface
{
    public interface IItemRepository : IRepository<Item>
    {
        Task UpdateAsync(Item entity);
    }
}
