using ZingCRM_Demo.Models;

namespace ZingCRM_Demo.Data.Repository.Interface
{
    public interface IUserRepository : IRepository<ApplicationUser>
    {
        Task UpdateAsync(ApplicationUser entity);
    }
}
