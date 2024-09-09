using Microsoft.EntityFrameworkCore;
using ZingCRM_Demo.Models;
using ZingCRM_Demo.Data.Repository.Interface;

namespace ZingCRM_Demo.Data.Repository
{
    public class ProjectRepository(IDbContextFactory<ApplicationDbContext> contextFactory) : Repository<Project>(contextFactory), IProjectRepository
    {
        private readonly IDbContextFactory<ApplicationDbContext> _contextFactory = contextFactory;

        public async Task UpdateAsync(Project entity)
        {
            using var context = _contextFactory.CreateDbContext();

            context.Projects.Update(entity);
            await context.SaveChangesAsync();
        }

        public async Task UpdatePhaseAsync(int id, string phase)
        {
            using var context = _contextFactory.CreateDbContext();

            Project entity = context.Projects.FirstOrDefault(p => p.Id == id);
            entity.Phase = phase;

            context.Projects.Update(entity);
            await context.SaveChangesAsync();
        }
    }
}
