using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Borovec_Inventory
{
    internal class Bicycle : IShippable
    {
        private decimal price = 9.50m;
        private string name = "Bicycle";
        public decimal ShipCost { get { return price; } }
        public string Product { get { return name; } }
    }
}
