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
                // Load the existing project including its items
                var existingProject = await context.Projects
                    .Include(p => p.Items)
                    .SingleOrDefaultAsync(p => p.Id == entity.Id);

                if (existingProject == null)
                {
                    throw new Exception("Project not found");
                }

                // Find items to remove
                var itemsToRemove = existingProject.Items
                    .Where(dbItem => !entity.Items.Any(ei => ei.Id == dbItem.Id))
                    .ToList();
                if (itemsToRemove.Count > 0)
                {
                    // Remove items from context
                    context.Items.RemoveRange(itemsToRemove);

                    // Save all changes
                    await context.SaveChangesAsync();
                }
            }
            using (var context = _contextFactory.CreateDbContext())
            {
                try
                {
                    context.Projects.Update(entity);
                    // Save all changes
                    await context.SaveChangesAsync();
                }
                catch (Exception e)
                {
                    throw;
                }
            }
        }
    }
}
