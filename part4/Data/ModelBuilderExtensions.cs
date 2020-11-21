using part4.Models;
using Microsoft.EntityFrameworkCore;
namespace part4.Data
{
    public static class ModelBuilderExtensions
    {
        public static ModelBuilder Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(


                new Product
                {
                    Id = 1,
                    Name = "The Mini",
                    Description = "A small and lightweight PC for basic computing tasks.",
                    Price = 599.99m,
                    ImageName = "mini1.jpg",
                },

                new Product
                {
                    Id = 2,
                    Name = "The Business",
                    Description = "A Business PC for professional applications.",
                    Price = 799.99m,
                    ImageName = "business1.jpg",
                },

                new Product
                {
                    Id = 3,
                    Name = "The Gamer",
                    Description = "A PC for playing all of the latest and greatest video games.",
                    Price = 999.99m,
                    ImageName = "gamer1.jpg",
                }

            );
            return modelBuilder;
        }
    }
}