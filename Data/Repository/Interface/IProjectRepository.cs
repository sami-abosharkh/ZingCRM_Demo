using ZingCRM_Demo.Models;

namespace ZingCRM_Demo.Data.Repository.Interface
{
public interface IProjectRepository : IRepository<ProjectM>
{
Task UpdateAsync(ProjectM entity);
}
}
