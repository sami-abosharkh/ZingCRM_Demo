using Microsoft.EntityFrameworkCore;
using ZingCRM_Demo.Models;
using ZingCRM_Demo.Data.Repository.Interface;

namespace ZingCRM_Demo.Data.Repository
{
    public class UserRepository : Repository<ApplicationUser>, IUserRepository
    {
        private IDbContextFactory<ApplicationDbContext> _contextFactory;
        public UserRepository(IDbContextFactory<ApplicationDbContext> contextFactory) : base(contextFactory)
        {
            _contextFactory = contextFactory;
        }
        public async Task UpdateAsync(ApplicationUser entity)
        {
            using (var context = _contextFactory.CreateDbContext())
            {
                context.ApplicationUser.Update(entity);
                await context.SaveChangesAsync();
            }
        }
    }
}
