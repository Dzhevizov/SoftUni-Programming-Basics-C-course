using System;

namespace Fuel_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine();
            double litersInTank = double.Parse(Console.ReadLine());

            if (fuelType == "Diesel")
            {
                if (litersInTank >= 25)
                {
                    Console.WriteLine($"You have enough diesel.");
                }
                else
                {
                    Console.WriteLine($"Fill your tank with diesel!");
                }
            }
            else if (fuelType == "Gasoline")
            {
                if (litersInTank >= 25)
                {
                    Console.WriteLine($"You have enough gasoline.");
                }
                else
                {
                    Console.WriteLine($"Fill your tank with gasoline!");
                }
            }
            else if (fuelType == "Gas")
            {
                if (litersInTank >= 25)
                {
                    Console.WriteLine($"You have enough gas.");
                }
                else
                {
                    Console.WriteLine($"Fill your tank with gas!");
                }
            }
            else
            {
                Console.WriteLine("Invalid fuel!");
            }
        }
    }
}
