using System;
using System.Collections.Generic;

namespace GaryWholesale
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating new  electric cars.
            Electric Tesla = new Electric();
            Electric Feat500 = new Electric();
            Electric Audi = new Electric();

            //creating Gas vehicles
            GasCar Honda = new GasCar();
            GasCar Hyundia = new GasCar();
            GasCar Toyot = new GasCar();

            // creating list of electric cars
            var electric = new List<Electric>(){
                Tesla, Feat500, Audi
            };

            //creating List of gas vehicles
            var GasVehicles = new List<GasCar>()
            {
                Honda, Hyundia, Toyot
            };
            
            //now u can create a new car and u can give a name and capacity
            Tesla.Name = "Modal X";
            Console.WriteLine($"{Tesla.Name}");
            Honda.Name = "Accord";
            Honda.Capacity = 440;

            // now u can refual all the gas cars
            GasStation newCar = new GasStation();
            newCar.Refuel(Honda.Name, Honda);


            // now u can refual all the electric cars
            BatteryStation newcar2 = new BatteryStation();
            newcar2.Refuel(Tesla.Name, Tesla);




        }
    }
}