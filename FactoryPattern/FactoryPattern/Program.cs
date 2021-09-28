using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a the number 2 to make a motorcycle or the number 4 to make a car");
            string userInput = Console.ReadLine();
            IVehicle userChoice = VehicleFactory.GetVehicle(userInput);
            userChoice.Drive();
        }
    }
}
