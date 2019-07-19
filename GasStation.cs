using System;
using System.Collections.Generic;

namespace GaryWholesale
{
    public class GasStation : Istation<GasCar>
    {
        public Dictionary<string, GasCar> Electric = new Dictionary<string, GasCar>();
        public void Refuel(string name, GasCar item)
        {
            Electric.Add(name, item);
            Console.WriteLine($"The {name} have a full gas now.");
        }
    }
}