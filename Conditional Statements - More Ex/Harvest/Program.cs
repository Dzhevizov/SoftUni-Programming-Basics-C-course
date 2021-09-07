using System;

namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            double Y = double.Parse(Console.ReadLine());
            int Z = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            double grapesForWine = X * Y * 0.4;
            double totalWine = grapesForWine / 2.5;

            if (totalWine < Z)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(Z-totalWine)} liters wine needed.");
            }

            else
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(totalWine)} liters.");
                Console.WriteLine($"{Math.Ceiling(totalWine-Z)} liters left -> {Math.Ceiling((totalWine - Z)/workers)} liters per person.");
            }
        }
    }
}
