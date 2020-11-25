using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace part4.Models
{
    public class UpgradePJT
    {
        public int UpgradePJTID { get; set; }
        public int OrderID { get; set; }
        public int UpgradeID { get; set; }

        public Order Order { get; set; }
        public Upgrade Upgrade { get; set; }
    }
}
