using ZingCRM_Demo.Models;

namespace ZingCRM_Demo.Data.Repository.Interface
{
    public interface IProjectRepository : IRepository<Project>
    {
        Task UpdateAsync(Project entity);
        Task UpdatePhaseAsync(int id, string phase);
    }
}
