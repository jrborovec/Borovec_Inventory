using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borovec_Inventory
{
    internal class Crackers : IShippable
    {
        private int count;
        private decimal price = 0.57m;
        private string name = "Cracker";
        public decimal ShipCost { get { return price; } }
        public string Product { get { return name; } }
    }
}
