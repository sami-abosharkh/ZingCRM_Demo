using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ZingCRM_Demo.Models;
using ZingCRM_Demo.Utilities;

namespace ZingCRM_Demo.Data.DbInitializer
{
    public class DbInitializer : IDbInitializer
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ApplicationDbContext _db;
        private readonly ILogger<DbInitializer> _logger;

        public DbInitializer(
        UserManager<ApplicationUser> userManager,
        RoleManager<IdentityRole> roleManager,
        ApplicationDbContext db,
        ILogger<DbInitializer> logger)
        {
            _roleManager = roleManager;
            _userManager = userManager;
            _db = db;
            _logger = logger;
        }
        public async Task Initialize()
        {
            //migrations if they are not applied
            if (_db.Database.GetPendingMigrations().Count() > 0)
            {
                _db.Database.Migrate();
            }

            await InitializeRoles();
            await InitializeAdmin();
        }
        private async Task InitializeRoles()
        {
            //create roles if they are not created
            if (!_roleManager.RoleExistsAsync(SD.Role_Admin).GetAwaiter().GetResult())
            {
                await _roleManager.CreateAsync(new IdentityRole(SD.Role_Admin));
                await _roleManager.CreateAsync(new IdentityRole(SD.Role_Manager));
                await _roleManager.CreateAsync(new IdentityRole(SD.Role_Accountant));
                await _roleManager.CreateAsync(new IdentityRole(SD.Role_OperationManager));
                await _roleManager.CreateAsync(new IdentityRole(SD.Role_ClientService));
            }
        }
        private async Task InitializeAdmin()
        {
            var adminUsers = await _userManager.GetUsersInRoleAsync(SD.Role_Admin);

            if (adminUsers.Count > 0) return;

            ApplicationUser adminUser = new ApplicationUser()
            {
                FirstName= "Admin",
                UserName = "admin@admin",
                Email = "admin@admin",
                CreatedAt = DateTime.Now,
                LockoutEnabled = false,
            };

            var result = await _userManager.CreateAsync(adminUser, "Admin121!");

            if (!result.Succeeded)
            {
                foreach (var err in result.Errors)
                {
                    _logger.LogError($"An error occurred while creating Admin account - {err.Code}: {err.Description}");
                }
                return;
            }

            _logger.LogInformation("Admin account was created Successfully");

            await _userManager.AddToRoleAsync(adminUser, SD.Role_Admin);
        }
    }
}