using System;

namespace Car_To_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string carClass = null;
            string carType = null;
            double price = 0;

            if (budget <= 100)
            {
                carClass = "Economy class";
                if (season == "Summer")
                {
                    carType = "Cabrio";
                    price = budget * 0.35;
                }
                else if (season == "Winter")
                {
                    carType = "Jeep";
                    price = budget * 0.65;
                }
            }
            else if (budget <= 500)
            {
                carClass = "Compact class";
                if (season == "Summer")
                {
                    carType = "Cabrio";
                    price = budget * 0.45;
                }
                else if (season == "Winter")
                {
                    carType = "Jeep";
                    price = budget * 0.80;
                }
            }
            else
            {
                carClass = "Luxury class";
                carType = "Jeep";
                price = budget * 0.90;
            }

            Console.WriteLine($"{carClass}");
            Console.WriteLine($"{carType} - {price:f2}");
        }
    }
}
