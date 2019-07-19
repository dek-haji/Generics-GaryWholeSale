using System;
using System.Collections.Generic;

namespace GaryWholesale
{
    public class BatteryStation : Istation<Electric>
    {

        public Dictionary<string, Electric> Electric = new Dictionary<string, Electric>();
        public void Refuel(string name, Electric item)
        {
            Electric.Add(name, item);
            Console.WriteLine($"The {name} have a full battery now.");
        }
    }
}