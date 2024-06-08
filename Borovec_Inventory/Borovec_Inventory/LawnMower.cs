using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borovec_Inventory
{
    internal class LawnMower : IShippable
    {
        private decimal price = 24.00m;
        private string name = "Lawn Mower";
        public decimal ShipCost { get { return price; } }
        public string Product { get { return name; } }
    }
}

