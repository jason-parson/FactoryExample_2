using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryExample_2
{
    static class VehicleFactory
    {


        public static IVehicle GetVehicle(string vehicleType) 
        {
            switch (vehicleType.ToLower()) 
            
            {
                case "4":
                    return new Car();
                case "3":
                    return new Truck();
                case "2":
                    return new Motocycle();
                default:
                    return new Car();

            
            
            }
        
        
        }
    }
}
