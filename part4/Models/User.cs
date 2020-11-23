using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace part4.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public ICollection<Order> Orders { get; set; }



    }
}
