using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borovec_Inventory
{
    internal class BaseballGlove : IShippable
    {
        private decimal price = 3.23m;
        private string name = "Baseball Glove";
        public decimal ShipCost { get { return price; } }
        public string Product { get { return name; } }

    }
}
