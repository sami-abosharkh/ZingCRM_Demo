using ZingCRM_Demo.Models;

namespace ZingCRM_Demo.Data.Repository.Interface
{
public interface IItemRepository : IRepository<ItemM>
{
Task UpdateAsync(ItemM entity);
}
}
