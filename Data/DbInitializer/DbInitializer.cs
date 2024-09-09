using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ZingCRM_Demo.Models;
using ZingCRM_Demo.Utilities;

namespace ZingCRM_Demo.Data.DbInitializer
{
    public class DbInitializer(
    ApplicationDbContext db,
    UserManager<ApplicationUser> userManager,
    RoleManager<IdentityRole> roleManager,
    ILogger<DbInitializer> logger) : IDbInitializer
    {
        private readonly ApplicationDbContext _db = db;
        private readonly UserManager<ApplicationUser> _userManager = userManager;
        private readonly RoleManager<IdentityRole> _roleManager = roleManager;
        private readonly ILogger<DbInitializer> _logger = logger;

        public async Task Initialize()
        {
            //migrations if they are not applied
            if (_db.Database.GetPendingMigrations().Any())
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

            if (adminUsers.Any()) return;

            ApplicationUser adminUser = new()
            {
                FirstName= "Admin",
                UserName = "admin@admin",
                Email = "admin@admin",
                TimeCreated = DateTime.Now,
                LockoutEnabled = false,
            };

            var result = await _userManager.CreateAsync(adminUser, "Admin121!");

            if (!result.Succeeded)
            {
                foreach (var err in result.Errors)
                {
                    _logger.LogError($"An error occurred while creating Admin account - {err.Code}: {err.Description}");
                }
            }
            else
            {
                _logger.LogInformation("Admin account was created Successfully");
                await _userManager.AddToRoleAsync(adminUser, SD.Role_Admin);
            }
        }
    }
}