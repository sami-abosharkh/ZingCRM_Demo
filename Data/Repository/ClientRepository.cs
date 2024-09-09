using Microsoft.EntityFrameworkCore;
using ZingCRM_Demo.Models;
using ZingCRM_Demo.Data.Repository.Interface;

namespace ZingCRM_Demo.Data.Repository
{
    public class ClientRepository(IDbContextFactory<ApplicationDbContext> contextFactory) : Repository<Client>(contextFactory), IClientRepository
    {
        private readonly IDbContextFactory<ApplicationDbContext> _contextFactory = contextFactory;

        public async Task UpdateAsync(Client entity)
        {
            using var context = _contextFactory.CreateDbContext();
            context.Clients.Update(entity);
            await context.SaveChangesAsync();
        }
    }
}
