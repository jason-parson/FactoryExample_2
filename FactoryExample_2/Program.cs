using System;

namespace FactoryExample_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please type the appropriate nubmer for the vehicle you would like. 4=Car, 3= Truck, 2= Motorcycle");
            string userVehicle = Console.ReadLine();



            IVehicle vehicle = VehicleFactory.GetVehicle(userVehicle);
            vehicle.Drive();
            Console.ReadLine();

        }
    }
}
