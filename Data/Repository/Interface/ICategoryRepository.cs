using ZingCRM_Demo.Models;

namespace ZingCRM_Demo.Data.Repository.Interface
{
    public interface ICategoryRepository : IRepository<Category>
    {
        Task UpdateAsync(Category entity);
    }
}
