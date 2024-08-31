using Microsoft.EntityFrameworkCore;
using ZingCRM_Demo.Models;
using ZingCRM_Demo.Data.Repository.Interface;

namespace ZingCRM_Demo.Data.Repository
{
public class ProjectRepository : Repository<ProjectM>, IProjectRepository
{
private IDbContextFactory<ApplicationDbContext> _contextFactory;
public ProjectRepository(IDbContextFactory<ApplicationDbContext> contextFactory) : base(contextFactory)
{
_contextFactory = contextFactory;
}
public async Task UpdateAsync(ProjectM entity)
{
using (var context = _contextFactory.CreateDbContext())
{
//context.Projects.Update(entity);
await context.SaveChangesAsync();
}
}
}
}
