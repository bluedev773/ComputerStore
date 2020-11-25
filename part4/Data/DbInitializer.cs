using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using part4.Data;
using part4.Models;

namespace part4.Data
{
    public class DbInitializer
    {
        public static void Initialize(OrderContext context)
        {
            context.Database.EnsureCreated();
            //Look for orders.
            if (context.Orders.Any())
            {
                return; //DB is seeded
            }


          //  var users = new User[]
         //   {
            //    new User{UserID=1,Name="Rick",Email="rick@gmail.com"},
             //   new User{UserID=2,Name="Morty",Email="morty@gmail.com"},
            //    new User{UserID=3,Name="Matthew",Email="litvinma773@hotmail.com"},
           // };
          //  context.Users.AddRange(users);
           // context.SaveChanges();

           // var products = new Product[]
           // {
           //     new Product{ProductID=1,Name="The Mini",Description="A small and lightweight PC for basic computing tasks.",Price=599.99m,ImageName="mini1.jpg"},
            //    new Product{ProductID=2,Name="The Business",Description="A Business PC for professional applications.",Price=799.99m,ImageName="business1.jpg"},
           //     new Product{ProductID=3,Name="The Gamer",Description="A PC for playing all of the latest and greatest video games.",Price=999.99m,ImageName="gamer1.jpg"},
           // };
           // context.Products.AddRange(products);
          //  context.SaveChanges();

           // var upgrades = new Upgrade[]
            //{
           //     new Upgrade{UpgradeID=1,UpgradeCategory="Storage",UpgradeName="256GB SSD",UpgradePrice=50},
            //    new Upgrade{UpgradeID=1,UpgradeCategory="CPU",UpgradeName="i5 9600k",UpgradePrice=200},
            //    new Upgrade{UpgradeID=1,UpgradeCategory="Memory",UpgradeName="16GB RAM",UpgradePrice=100}
           // };
           // context.Upgrades.AddRange(upgrades);
          //  context.SaveChanges();

         //   var orders = new Order[]
         //   {
           //     new Order{OrderID=1,UserID=1,ProductID=2,Date="2019-09-01"},
           //     new Order{OrderID=2,UserID=1,ProductID=3,Date="2019-09-02"},
            //    new Order{OrderID=3,UserID=2,ProductID=1,Date="2019-09-03"},
            //    new Order{OrderID=4,UserID=3,ProductID=2,Date="2019-08-01"}
           // };

           // context.Orders.AddRange(orders);
          //  context.SaveChanges();

            

        }
       

    }
}
