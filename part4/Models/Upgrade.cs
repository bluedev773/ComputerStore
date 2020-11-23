using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace part4.Models
{
    public class Upgrade
    {
        public int UpgradeID { get; set; }
        public string UpgradeName { get; set; }

        public string UpgradeCategory { get; set; }

        public int UpgradePrice { get; set; }
    }
}
