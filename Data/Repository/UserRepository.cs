using Microsoft.EntityFrameworkCore;
using ZingCRM_Demo.Models;
using ZingCRM_Demo.Data.Repository.Interface;

namespace ZingCRM_Demo.Data.Repository
{
    public class UserRepository(IDbContextFactory<ApplicationDbContext> contextFactory) : Repository<ApplicationUser>(contextFactory), IUserRepository
    {
        private readonly IDbContextFactory<ApplicationDbContext> _contextFactory = contextFactory;

        public async Task UpdateAsync(ApplicationUser entity)
        {
            using var context = _contextFactory.CreateDbContext();
            context.ApplicationUser.Update(entity);
            await context.SaveChangesAsync();
        }
    }
}
