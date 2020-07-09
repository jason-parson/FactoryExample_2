using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryExample_2
{
    class Motocycle : IVehicle
    {
        public void Drive()
        {

            var newVehicle = "Motorcycle";

            Console.WriteLine($"Building a new {newVehicle} !");


        }

    }
}
