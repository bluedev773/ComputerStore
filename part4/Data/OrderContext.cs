using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using part4.Models;

namespace part4.Data
{
    public class OrderContext : DbContext
    {
        public OrderContext (DbContextOptions<OrderContext> options)
            : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Upgrade> Upgrades { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Order>().ToTable("Order");
            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<Upgrade>().ToTable("Upgrade");

            modelBuilder.Entity<Upgrade>().HasData(
                new Upgrade { UpgradeID = 1, UpgradeCategory = "Storage", UpgradeName = "256GB SSD", UpgradePrice = 50 },
                new Upgrade { UpgradeID = 2, UpgradeCategory = "CPU", UpgradeName = "i5 9600k", UpgradePrice = 200 },
                new Upgrade { UpgradeID = 3, UpgradeCategory = "Memory", UpgradeName = "16GB RAM", UpgradePrice = 100 }
                );
            modelBuilder.Entity<Product>().HasData(
                new Product { ProductID = 1, Name = "The Mini", Description = "A small and lightweight PC for basic computing tasks.", Price = 599.99m, ImageName = "mini1.jpg" },
                new Product { ProductID = 2, Name = "The Business", Description = "A Business PC for professional applications.", Price = 799.99m, ImageName = "business1.jpg" },
                new Product { ProductID = 3, Name = "The Gamer", Description = "A PC for playing all of the latest and greatest video games.", Price = 999.99m, ImageName = "gamer1.jpg" }
                );

        }

    }
}
