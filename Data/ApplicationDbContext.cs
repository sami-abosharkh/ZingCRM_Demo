using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Reflection.Emit;
using ZingCRM_Demo.Models;

namespace ZingCRM_Demo.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); // Ensure the base configurations are applied.

            modelBuilder.Entity<Project>()
                .HasIndex(p => p.Number)
                .IsUnique();

            modelBuilder.Entity<Client>()
                .HasIndex(p => p.Name)
                .IsUnique();

            modelBuilder.Entity<Category>()
                .HasIndex(p => p.Name)
                .IsUnique();

            modelBuilder.Entity<PurchaseRequisition>()
                .HasIndex(p => p.Number)
                .IsUnique();

            // Seed data
            SeedCategories(modelBuilder);
            SeedItems(modelBuilder);
        }

        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<QuotationItem> QuotationItems { get; set; }
        public DbSet<PurchaseRequisition> PurchaseRequisitions { get; set; }
        public DbSet<RequisitionEntry> RequisitionEntries { get; set; }

        private static void SeedCategories(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Designs", Description = "Everything that has to do with 2D and 3D designs." },
                new Category { Id = 2, Name = "Electronics & Appliances", Description = "All Electronic and Appliances which include batteries and tablets." },
                new Category { Id = 3, Name = "Gifting", Description = "All items designated for gifting in an activity that is gifting related, which includes notebooks and vouchers." },
                new Category { Id = 4, Name = "Manpower", Description = "All promoters and supervisors." },
                new Category { Id = 5, Name = "Office Launches", Description = "All items that are required for an office launch, this includes the gifts and danglers and other production elements that were created for the office launch." },
                new Category { Id = 6, Name = "Official Documents", Description = "Anything that needed to be attested for a specific project." },
                new Category { Id = 7, Name = "Photography & Videography", Description = "All recruited photographers and videographers." },
                new Category { Id = 8, Name = "POSM Productions", Description = "All production elements within a project not including a giveaway and office launch project." },
                new Category { Id = 9, Name = "Logistics", Description = "Anything Logistics including Installation and Dismantling of any soft or hard POSM." },
                new Category { Id = 10, Name = "Promoting Material", Description = "Anything required to run a promotion activity which includes tables and uniforms." },
                new Category { Id = 11, Name = "Rental", Description = "All location rental costs." },
                new Category { Id = 12, Name = "Shipping International", Description = "All international shipments." },
                new Category { Id = 13, Name = "Shipping Local", Description = "All local shipments including store deployment." },
                new Category { Id = 14, Name = "Storage & Warehousing", Description = "All costs related to renting a temporary warehouse." },
                new Category { Id = 15, Name = "Travel Expenses", Description = "All travels and lodging for specific projects." },
                new Category { Id = 16, Name = "Programming", Description = "All VR and App Programming related costs." }
            );
        }
        private static void SeedItems(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>().HasData(
                // Manpower
                new Item { Id = 1, Name = "Male Promoter", CategoryId = 4 },
                new Item { Id = 2, Name = "Female Promoter", CategoryId = 4 },
                new Item { Id = 3, Name = "Male Supervisor", CategoryId = 4 },
                new Item { Id = 4, Name = "Female Supervisor", CategoryId = 4 },
                new Item { Id = 5, Name = "Male Usher", CategoryId = 4 },
                new Item { Id = 6, Name = "Female Usher", CategoryId = 4 },
                new Item { Id = 7, Name = "Laborer", CategoryId = 4 },

                // Designs
                new Item { Id = 8, Name = "HARD POSM: Gondola", CategoryId = 1 },
                new Item { Id = 9, Name = "HARD POSM: Gondola End Stand", CategoryId = 1 },
                new Item { Id = 10, Name = "HARD POSM: 60x40 FSU", CategoryId = 1 },
                new Item { Id = 11, Name = "HARD POSM: 50x50 FSU", CategoryId = 1 },
                new Item { Id = 12, Name = "HARD POSM: 1x1", CategoryId = 1 },
                new Item { Id = 13, Name = "HARD POSM: 2x1", CategoryId = 1 },
                new Item { Id = 14, Name = "HARD POSM: 2x2", CategoryId = 1 },
                new Item { Id = 15, Name = "HARD POSM: 3x2", CategoryId = 1 },
                new Item { Id = 16, Name = "HARD POSM: 3x3", CategoryId = 1 },
                new Item { Id = 17, Name = "HARD POSM: 4x2", CategoryId = 1 },
                new Item { Id = 18, Name = "HARD POSM: 4x4", CategoryId = 1 },
                new Item { Id = 19, Name = "HARD POSM: 5x2", CategoryId = 1 },
                new Item { Id = 20, Name = "HARD POSM: 5x3", CategoryId = 1 },
                new Item { Id = 21, Name = "HARD POSM: 5x5", CategoryId = 1 },
                new Item { Id = 22, Name = "Exhibition Booth 3x3", CategoryId = 1 },
                new Item { Id = 23, Name = "Exhibition Booth 5x3", CategoryId = 1 },
                new Item { Id = 24, Name = "Exhibition Booth 5x5", CategoryId = 1 },
                new Item { Id = 25, Name = "Exhibition Booth 7x5", CategoryId = 1 },
                new Item { Id = 26, Name = "D-Com Banner", CategoryId = 1 },
                new Item { Id = 27, Name = "Social Media Post", CategoryId = 1 },
                new Item { Id = 28, Name = "SOFT POSM: Danglers", CategoryId = 1 },
                new Item { Id = 29, Name = "SOFT POSM: Wobblers", CategoryId = 1 },
                new Item { Id = 30, Name = "SOFT POSM: Dividers", CategoryId = 1 },
                new Item { Id = 31, Name = "SOFT POSM: Shelf Strips", CategoryId = 1 },
                new Item { Id = 32, Name = "SOFT POSM: Base Wrap", CategoryId = 1 },
                new Item { Id = 33, Name = "SOFT POSM: Floor Sticker", CategoryId = 1 },
                new Item { Id = 34, Name = "SOFT POSM: Tent Card", CategoryId = 1 },

                // Electronics & Appliances
                new Item { Id = 35, Name = "Phone", CategoryId = 2 },
                new Item { Id = 36, Name = "Tablet", CategoryId = 2 },
                new Item { Id = 37, Name = "Screen", CategoryId = 2 },

                // Gifting
                new Item { Id = 38, Name = "Voucher", CategoryId = 3 },
                new Item { Id = 39, Name = "Pen", CategoryId = 3 },
                new Item { Id = 40, Name = "Notebook", CategoryId = 3 },
                new Item { Id = 41, Name = "Box", CategoryId = 3 },

                // Photography & Videography
                new Item { Id = 42, Name = "Videography", CategoryId = 7 },
                new Item { Id = 43, Name = "Photography", CategoryId = 7 },
                new Item { Id = 44, Name = "Photography & Videography", CategoryId = 7 },
                new Item { Id = 45, Name = "Drone Videography", CategoryId = 7 },
                new Item { Id = 46, Name = "Drone Photography", CategoryId = 7 },

                // POSM Productions
                new Item { Id = 47, Name = "HARD POSM: Gondola", CategoryId = 8 },
                new Item { Id = 48, Name = "HARD POSM: Gondola End Stand", CategoryId = 8 },
                new Item { Id = 49, Name = "HARD POSM: 60x40 FSU", CategoryId = 8 },
                new Item { Id = 50, Name = "HARD POSM: 50x50 FSU", CategoryId = 8 },
                new Item { Id = 51, Name = "HARD POSM: 1x1", CategoryId = 8 },
                new Item { Id = 52, Name = "HARD POSM: 2x1", CategoryId = 8 },
                new Item { Id = 53, Name = "HARD POSM: 2x2", CategoryId = 8 },
                new Item { Id = 54, Name = "HARD POSM: 3x2", CategoryId = 8 },
                new Item { Id = 55, Name = "HARD POSM: 3x3", CategoryId = 8 },
                new Item { Id = 56, Name = "HARD POSM: 4x2", CategoryId = 8 },
                new Item { Id = 57, Name = "HARD POSM: 4x4", CategoryId = 8 },
                new Item { Id = 58, Name = "HARD POSM: 5x2", CategoryId = 8 },
                new Item { Id = 59, Name = "HARD POSM: 5x3", CategoryId = 8 },
                new Item { Id = 60, Name = "HARD POSM: 5x5", CategoryId = 8 },
                new Item { Id = 61, Name = "Exhibition Booth 3x3", CategoryId = 8 },
                new Item { Id = 62, Name = "Exhibition Booth 5x3", CategoryId = 8 },
                new Item { Id = 63, Name = "Exhibition Booth 5x5", CategoryId = 8 },
                new Item { Id = 64, Name = "Exhibition Booth 7x5", CategoryId = 8 },
                new Item { Id = 65, Name = "SOFT POSM: Danglers", CategoryId = 8 },
                new Item { Id = 66, Name = "SOFT POSM: Wobblers", CategoryId = 8 },
                new Item { Id = 67, Name = "SOFT POSM: Dividers", CategoryId = 8 },
                new Item { Id = 68, Name = "SOFT POSM: Shelf Strips", CategoryId = 8 },
                new Item { Id = 69, Name = "SOFT POSM: Base Wrap", CategoryId = 8 },
                new Item { Id = 70, Name = "SOFT POSM: Floor Sticker", CategoryId = 8 },
                new Item { Id = 71, Name = "SOFT POSM: Tent Card", CategoryId = 8 },

                // Logistics
                new Item { Id = 72, Name = "Stand Deployment and Installation", CategoryId = 9 },
                new Item { Id = 73, Name = "Booth Deployment and Installation", CategoryId = 9 },

                // Promoting Material
                new Item { Id = 74, Name = "Uniforms", CategoryId = 10 },
                new Item { Id = 75, Name = "Promoter Tables", CategoryId = 10 },
                new Item { Id = 76, Name = "Decorations", CategoryId = 10 },
                new Item { Id = 77, Name = "Branded Cups", CategoryId = 10 },
                new Item { Id = 78, Name = "Unbranded Cups", CategoryId = 10 },
                new Item { Id = 79, Name = "Spoons", CategoryId = 10 },
                new Item { Id = 80, Name = "Forks", CategoryId = 10 },
                new Item { Id = 81, Name = "Kraft Plates", CategoryId = 10 },
                new Item { Id = 82, Name = "Hair Nets", CategoryId = 10 },
                new Item { Id = 83, Name = "Masks", CategoryId = 10 },
                new Item { Id = 84, Name = "Gloves", CategoryId = 10 },

                // Rental
                new Item { Id = 85, Name = "Mall Rental", CategoryId = 11 },
                new Item { Id = 86, Name = "Supermarket Rentals", CategoryId = 11 },
                new Item { Id = 87, Name = "Event Rentals", CategoryId = 11 },

                // Shipping - International
                new Item { Id = 88, Name = "KSA - UAE", CategoryId = 12 },
                new Item { Id = 89, Name = "UAE - KSA", CategoryId = 12 },

                // Shipping - Local
                new Item { Id = 90, Name = "Jeddah - Riyadh", CategoryId = 13 },
                new Item { Id = 91, Name = "Jeddah - Dammam", CategoryId = 13 },
                new Item { Id = 92, Name = "Riyadh - Jeddah", CategoryId = 13 },
                new Item { Id = 93, Name = "Riyadh - Dammam", CategoryId = 13 },
                new Item { Id = 94, Name = "Dammam - Riyadh", CategoryId = 13 },
                new Item { Id = 95, Name = "Dammam - Jeddah", CategoryId = 13 },
                new Item { Id = 96, Name = "Jeddah - Remote Cities", CategoryId = 13 },

                // Programming
                new Item { Id = 97, Name = "Microsite", CategoryId = 16 },
                new Item { Id = 98, Name = "Apps", CategoryId = 16 }
            );
        }
    }
}