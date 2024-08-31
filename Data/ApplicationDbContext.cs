using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ZingCRM_Demo.Models;

namespace ZingCRM_Demo.Data
{
public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
public DbSet<ApplicationUser> ApplicationUser { get; set; }
public DbSet<ProjectM> Projects { get; set; }
public DbSet<ItemM> Items { get; set; }
}
}
