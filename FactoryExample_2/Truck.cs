using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryExample_2
{
    class Truck : IVehicle 
    {
        public void Drive()
        {
            var newVehicle = "Truck";

            
            Console.WriteLine($"Building a new {newVehicle} !");


        }

    }
}
