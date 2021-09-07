using System;

namespace Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numChrysanthemums = int.Parse(Console.ReadLine());
            int numRoses = int.Parse(Console.ReadLine());
            int numTulips = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string isHoliday = Console.ReadLine();

            double chrysanthemumsPrice = 0;
            double rosesPrice = 0;
            double tulipsPrice = 0;
            double totalPrice = 0;

            switch (season)
            {
                case "Spring":
                case "Summer":
                    chrysanthemumsPrice = 2.00;
                    rosesPrice = 4.10;
                    tulipsPrice = 2.50;
                    break;
                case "Autumn":
                case "Winter":
                    chrysanthemumsPrice = 3.75;
                    rosesPrice = 4.50;
                    tulipsPrice = 4.15;
                    break;
            }

            if (isHoliday == "Y")
            {
                chrysanthemumsPrice *= 1.15;
                rosesPrice *= 1.15;
                tulipsPrice *= 1.15;
            }
            
            totalPrice = numChrysanthemums * chrysanthemumsPrice + numRoses * rosesPrice + numTulips * tulipsPrice;

            if (season == "Spring" && numTulips > 7)
            {
                totalPrice *= 0.95;
            }

            if (season == "Winter" && numRoses >= 10)
            {
                totalPrice *= 0.90;
            }

            if ((numChrysanthemums + numRoses + numTulips) > 20)
            {
                totalPrice *= 0.80;
            }

            totalPrice += 2.00;

            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
