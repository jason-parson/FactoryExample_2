using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryExample_2
{
    class Car : IVehicle
    {    
        
        public void Drive()
        {
            var newVehicle = "Car";

            Console.WriteLine($"Building a new {newVehicle} !");
        
        }



    }
}
