using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borovec_Inventory
{
    internal class CellPhone : IShippable
    {
        private decimal price = 5.95m;
        private string name = "Cell Phone";
        public decimal ShipCost { get { return price; } }
        public string Product { get { return name; } }
    }
}
