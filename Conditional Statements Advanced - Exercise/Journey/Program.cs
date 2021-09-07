using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = null;
            string holidayType = null;
            double totalCost = 0;

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    totalCost = budget * 0.3;
                    holidayType = "Camp";
                }
                else if (season == "winter")
                {
                    totalCost = budget * 0.7;
                    holidayType = "Hotel";
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    totalCost = budget * 0.4;
                    holidayType = "Camp";
                }
                else if (season == "winter")
                {
                    totalCost = budget * 0.8;
                    holidayType = "Hotel";
                }
            }
            else
            {
                destination = "Europe";
                totalCost = budget * 0.9;
                holidayType = "Hotel";
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{holidayType} - {totalCost:f2}");
        }
    }
}
