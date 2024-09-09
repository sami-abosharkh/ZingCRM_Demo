using ZingCRM_Demo.Models;

namespace ZingCRM_Demo.Data.Repository.Interface
{
    public interface IClientRepository : IRepository<Client>
    {
        Task UpdateAsync(Client entity);
    }
}
