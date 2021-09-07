using System;

namespace Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermen = int.Parse(Console.ReadLine());

            double rentPrice = 0;
            switch (season)
            {
                case "Spring":
                    rentPrice = 3000;
                    break;
                case "Summer":
                case "Autumn":
                    rentPrice = 4200;
                    break;
                case "Winter":
                    rentPrice = 2600;
                    break;
            }

            if (fishermen <= 6)
            {
                rentPrice -= rentPrice * 0.10;
            }
            else if (fishermen <= 11)
            {
                rentPrice -= rentPrice * 0.15;
            }
            else
            {
                rentPrice -= rentPrice * 0.25;
            }

            if (fishermen % 2 == 0 && season != "Autumn")
            {
                rentPrice -= rentPrice * 0.05;
            }

            if (budget >= rentPrice)
            {
                Console.WriteLine($"Yes! You have {budget - rentPrice:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {rentPrice - budget:f2} leva.");
            }
        }   

    }
}
