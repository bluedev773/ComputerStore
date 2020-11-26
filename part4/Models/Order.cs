using Microsoft.AspNetCore.Mvc;
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
        public string OrderPrice { get; set; }
        public string UserID { get; set; }
        public int ProductID { get; set; }
        public DateTime OrderDate { get; set; }
        public ICollection<UpgradePJT> UpgradePJT { get; set; }
        public Product Product { get; set; }
        //public Upgrade Upgrades { get; set; }


    }
}
