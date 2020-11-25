using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace part4.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public string UserID { get; set; }
        public int ProductID { get; set; }
        //public List<int> UpgradeID { get; set; }
        public string Date { get; set; }

        public Product Product { get; set; }
       // public ICollection<Upgrade> Upgrades { get; set; }


    }
}
