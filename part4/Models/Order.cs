using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace part4.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public int UserID { get; set; }
        public int ProductID { get; set; }

        public string Date { get; set; }

        public User User { get; set; }
        public Product Product { get; set; }
    }
}
