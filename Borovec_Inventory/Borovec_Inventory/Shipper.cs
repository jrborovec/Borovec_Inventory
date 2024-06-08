using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Borovec_Inventory
{
    
    internal class Shipper
    {
        private int shipment=0;

        public void Add(IShippable item, IShippable[] shippables)
        {
            if (shipment < 10)
            {
                int index = Array.IndexOf(shippables, null);
                if (index < 10)
                {
                    shippables[index] = item;
                    shipment++;
                }
            }
            else
            {
                Console.WriteLine("Shipment has reaching its maximum size");
            }
        }

        public void List(Bicycle[] bicycles, LawnMower[] lawnMowers, CellPhone[] cellPhones, BaseballGlove[] baseballGloves, Crackers[] cracker)
        {
            Console.WriteLine("Shipment Manifest");
            if (bicycles.Count(x => x != null) == 1) { Console.WriteLine(bicycles.Count(x => x != null) + " Bicycle"); }
            else if (bicycles.Count(x => x != null) > 1) { Console.WriteLine(bicycles.Count(x => x != null) + " Bicycles"); }
            if (lawnMowers.Count(x => x != null) == 1) { Console.WriteLine(lawnMowers.Count(x => x != null) + " Lawn Mower"); }
            else if (lawnMowers.Count(x => x != null) > 1) { Console.WriteLine(lawnMowers.Count(x => x != null) + " Lawn Mowers"); }
            if (cellPhones.Count(x => x != null) == 1) { Console.WriteLine(cellPhones.Count(x => x != null) + " Cell Phone"); }
            else if (cellPhones.Count(x => x != null) > 1) { Console.WriteLine(cellPhones.Count(x => x != null) + " Cell Phones"); }
            if (baseballGloves.Count(x => x != null) == 1) { Console.WriteLine(baseballGloves.Count(x => x != null) + " Baseball Glove"); }
            else if (baseballGloves.Count(x => x != null) > 1) { Console.WriteLine(baseballGloves.Count(x => x != null) + " Baseball Gloves"); }
            if (cracker.Count(x => x != null) >= 1) { Console.WriteLine(cracker.Count(x => x != null) + " Crackers"); }
        }

        public decimal Total(Bicycle[] bicycles, LawnMower[] lawnMowers, CellPhone[] cellPhones, BaseballGlove[] baseballGloves, Crackers[] cracker)
        {
            decimal total = 0;
            if (bicycles.Count(x => x != null) > 0) { total += bicycles.Count(x => x != null) * bicycles[0].ShipCost; }
            if (lawnMowers.Count(x => x != null) > 0) { total += lawnMowers.Count(x => x != null) * lawnMowers[0].ShipCost; }
            if (cellPhones.Count(x => x != null) > 0) { total += cellPhones.Count(x => x != null) * cellPhones[0].ShipCost; }
            if (baseballGloves.Count(x => x != null) > 0) { total += baseballGloves.Count(x => x != null) * baseballGloves[0].ShipCost; }
            if (cracker.Count(x => x != null) > 0) { total += cracker.Count(x => x != null) * cracker[0].ShipCost; }
            return total;
        }
    }

}


