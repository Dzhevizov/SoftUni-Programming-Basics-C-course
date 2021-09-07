using System;

namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int foodLeft = int.Parse(Console.ReadLine());
            double dogFoodPerDay = double.Parse(Console.ReadLine());
            double catFoodPerDay = double.Parse(Console.ReadLine());
            double turtleFoodPerDay = double.Parse(Console.ReadLine());
            double foodNeeded = (dogFoodPerDay + catFoodPerDay + turtleFoodPerDay / 1000) * days;

            if (foodLeft >= foodNeeded)
            {
                Console.WriteLine($"{Math.Floor(foodLeft-foodNeeded)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(foodNeeded-foodLeft)} more kilos of food are needed.");
            }

        }
    }
}
