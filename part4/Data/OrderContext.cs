using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using part4.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace part4.Data
{
    public class OrderContext : IdentityDbContext
    {
        public OrderContext (DbContextOptions<OrderContext> options)
            : base(options)
        {
        }
        
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Upgrade> Upgrades { get; set; }
        public DbSet<UpgradePJT> UpgradePJTs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Order>().ToTable("Order");
            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<Upgrade>().ToTable("Upgrade");
            modelBuilder.Entity<UpgradePJT>().ToTable("UpgradePJT");


            modelBuilder.Entity<Upgrade>().HasData(
               //mini pc
               new Upgrade { UpgradeID = 1, UpgradeCategory = "CPU", UpgradeName = "i3 8130u", UpgradePrice = 0 },
               new Upgrade { UpgradeID = 2, UpgradeCategory = "CPU", UpgradeName = "i5 8250u", UpgradePrice = 50 },
               new Upgrade { UpgradeID = 3, UpgradeCategory = "CPU", UpgradeName = "i7 8550u", UpgradePrice = 100 },
               new Upgrade { UpgradeID = 4, UpgradeCategory = "Memory", UpgradeName = "8 Gb", UpgradePrice = 0 },
               new Upgrade { UpgradeID = 5, UpgradeCategory = "Memory", UpgradeName = "16 Gb", UpgradePrice = 100 },
               new Upgrade { UpgradeID = 6, UpgradeCategory = "Storage", UpgradeName = "1 Tb HDD", UpgradePrice = 0 },
               new Upgrade { UpgradeID = 7, UpgradeCategory = "Storage", UpgradeName = "128 Gb SSD", UpgradePrice = 0 },
               new Upgrade { UpgradeID = 8, UpgradeCategory = "Storage", UpgradeName = "256 Gb SSD", UpgradePrice = 60 },
               new Upgrade { UpgradeID = 9, UpgradeCategory = "Storage", UpgradeName = "512 Gb SSD", UpgradePrice = 120 },
               new Upgrade { UpgradeID = 10, UpgradeCategory = "Video", UpgradeName = "Integrated", UpgradePrice = 0 },
               new Upgrade { UpgradeID = 11, UpgradeCategory = "Sound", UpgradeName = "Integrated", UpgradePrice = 0 },
               new Upgrade { UpgradeID = 12, UpgradeCategory = "OS", UpgradeName = "None", UpgradePrice = 0 },
               new Upgrade { UpgradeID = 13, UpgradeCategory = "OS", UpgradeName = "Ubuntu", UpgradePrice = 0 },
               new Upgrade { UpgradeID = 14, UpgradeCategory = "OS", UpgradeName = "Win 10 Home", UpgradePrice = 70 },
               //business pc
               new Upgrade { UpgradeID = 15, UpgradeCategory = "CPU", UpgradeName = "i3 10100", UpgradePrice = 0 },
               new Upgrade { UpgradeID = 16, UpgradeCategory = "CPU", UpgradeName = "i5 10400", UpgradePrice = 50 },
               new Upgrade { UpgradeID = 17, UpgradeCategory = "CPU", UpgradeName = "i5 10600", UpgradePrice = 80 },
               new Upgrade { UpgradeID = 18, UpgradeCategory = "CPU", UpgradeName = "i7 10700", UpgradePrice = 140 },
               new Upgrade { UpgradeID = 19, UpgradeCategory = "CPU", UpgradeName = "i9 10900", UpgradePrice = 200 },
               new Upgrade { UpgradeID = 20, UpgradeCategory = "Memory", UpgradeName = "8 Gb", UpgradePrice = 0 },
               new Upgrade { UpgradeID = 21, UpgradeCategory = "Memory", UpgradeName = "16 Gb", UpgradePrice = 100 },
               new Upgrade { UpgradeID = 22, UpgradeCategory = "Memory", UpgradeName = "32 Gb", UpgradePrice = 200 },
               new Upgrade { UpgradeID = 23, UpgradeCategory = "Storage", UpgradeName = "1 Tb HDD", UpgradePrice = 0 },
               new Upgrade { UpgradeID = 24, UpgradeCategory = "Storage", UpgradeName = "256 Gb SSD", UpgradePrice = 60 },
               new Upgrade { UpgradeID = 25, UpgradeCategory = "Storage", UpgradeName = "512 Gb SSD", UpgradePrice = 120 },
               new Upgrade { UpgradeID = 26, UpgradeCategory = "Storage", UpgradeName = "1 Tb SSD", UpgradePrice = 240 },
               new Upgrade { UpgradeID = 27, UpgradeCategory = "Video", UpgradeName = "Integrated", UpgradePrice = 0 },
               new Upgrade { UpgradeID = 28, UpgradeCategory = "Video", UpgradeName = "Quadro P620", UpgradePrice = 300 },
               new Upgrade { UpgradeID = 29, UpgradeCategory = "Video", UpgradeName = "Quadro P1000", UpgradePrice = 550 },
               new Upgrade { UpgradeID = 30, UpgradeCategory = "Sound", UpgradeName = "Integrated", UpgradePrice = 0 },
               new Upgrade { UpgradeID = 31, UpgradeCategory = "Sound", UpgradeName = "Sound Blaster 1000", UpgradePrice = 40 },
               new Upgrade { UpgradeID = 32, UpgradeCategory = "OS", UpgradeName = "None", UpgradePrice = 0 },
               new Upgrade { UpgradeID = 33, UpgradeCategory = "OS", UpgradeName = "Ubuntu", UpgradePrice = 0 },
               new Upgrade { UpgradeID = 34, UpgradeCategory = "OS", UpgradeName = "Win 10 Home", UpgradePrice = 70 },
               new Upgrade { UpgradeID = 35, UpgradeCategory = "OS", UpgradeName = "Win 10 Pro", UpgradePrice = 110 },
               //gamer pc
               new Upgrade { UpgradeID = 36, UpgradeCategory = "CPU", UpgradeName = "i5 9400", UpgradePrice = 0 },
               new Upgrade { UpgradeID = 37, UpgradeCategory = "CPU", UpgradeName = "i5 10400F", UpgradePrice = 75 },
               new Upgrade { UpgradeID = 38, UpgradeCategory = "CPU", UpgradeName = "i7 10700k", UpgradePrice = 150 },
               new Upgrade { UpgradeID = 39, UpgradeCategory = "Memory", UpgradeName = "8 Gb", UpgradePrice = 0 },
               new Upgrade { UpgradeID = 40, UpgradeCategory = "Memory", UpgradeName = "16 Gb", UpgradePrice = 100 },
               new Upgrade { UpgradeID = 41, UpgradeCategory = "Memory", UpgradeName = "32 Gb", UpgradePrice = 200 },
               new Upgrade { UpgradeID = 42, UpgradeCategory = "Storage", UpgradeName = "256 Gb SSD", UpgradePrice = 60 },
               new Upgrade { UpgradeID = 43, UpgradeCategory = "Storage", UpgradeName = "512 Gb SSD", UpgradePrice = 120 },
               new Upgrade { UpgradeID = 44, UpgradeCategory = "Storage", UpgradeName = "1 Tb SSD", UpgradePrice = 240 },
               new Upgrade { UpgradeID = 45, UpgradeCategory = "Video", UpgradeName = "1650 Ti", UpgradePrice = 0 },
               new Upgrade { UpgradeID = 46, UpgradeCategory = "Video", UpgradeName = "1660 Ti", UpgradePrice = 100 },
               new Upgrade { UpgradeID = 47, UpgradeCategory = "Video", UpgradeName = "RTX 2060", UpgradePrice = 150 },
               new Upgrade { UpgradeID = 48, UpgradeCategory = "Video", UpgradeName = "RTX 2070", UpgradePrice = 300 },
               new Upgrade { UpgradeID = 49, UpgradeCategory = "Sound", UpgradeName = "Integrated", UpgradePrice = 0 },
               new Upgrade { UpgradeID = 50, UpgradeCategory = "Sound", UpgradeName = "Sound Blaster 5000", UpgradePrice = 40 },
               new Upgrade { UpgradeID = 51, UpgradeCategory = "Sound", UpgradeName = "Sound Blaster 10000", UpgradePrice = 100 },
               new Upgrade { UpgradeID = 52, UpgradeCategory = "OS", UpgradeName = "Win 10 Home", UpgradePrice = 0 },
               new Upgrade { UpgradeID = 53, UpgradeCategory = "OS", UpgradeName = "Win 10 Pro", UpgradePrice = 40 }

               );
            modelBuilder.Entity<Product>().HasData(
                new Product { ProductID = 1, Name = "The Mini", Description = "A small and lightweight PC for basic computing tasks.", Price = 599.99m, ImageName = "mini1.jpg" },
                new Product { ProductID = 2, Name = "The Business", Description = "A Business PC for professional applications.", Price = 799.99m, ImageName = "business1.jpg" },
                new Product { ProductID = 3, Name = "The Gamer", Description = "A PC for playing all of the latest and greatest video games.", Price = 999.99m, ImageName = "gamer1.jpg" }
                );

            modelBuilder.Entity<Order>().HasData(
                new Order { OrderID = 1, ProductID = 1, OrderDate = new DateTime(2019, 08, 25) },
                new Order { OrderID = 2, ProductID = 2, OrderDate = new DateTime(2019, 09, 29) }
                );
            modelBuilder.Entity<UpgradePJT>().HasData(
                new UpgradePJT { UpgradePJTID=1,OrderID = 1, UpgradeID = 1 },
                new UpgradePJT { UpgradePJTID = 2,OrderID = 1, UpgradeID = 4 },
                new UpgradePJT { UpgradePJTID = 3, OrderID = 1, UpgradeID = 6 },
                new UpgradePJT { UpgradePJTID = 4, OrderID = 1, UpgradeID = 10 },
                new UpgradePJT { UpgradePJTID = 5, OrderID = 1, UpgradeID = 11 },
                new UpgradePJT { UpgradePJTID = 6, OrderID = 1, UpgradeID = 12 },

                new UpgradePJT { UpgradePJTID = 7, OrderID = 2, UpgradeID = 15 },
                new UpgradePJT { UpgradePJTID = 8, OrderID = 2, UpgradeID = 20 },
                new UpgradePJT { UpgradePJTID = 9, OrderID = 2, UpgradeID = 23 },
                new UpgradePJT { UpgradePJTID = 10, OrderID = 2, UpgradeID = 27 },
                new UpgradePJT { UpgradePJTID = 11, OrderID = 2, UpgradeID = 30 },
                new UpgradePJT { UpgradePJTID = 12, OrderID = 2, UpgradeID = 32 }
                );

            //TODO:


        }

    }
}
