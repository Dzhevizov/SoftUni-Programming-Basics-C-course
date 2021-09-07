using System;

namespace Supplies_for_School
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutesPerWalk = int.Parse(Console.ReadLine());
            int numWalks = int.Parse(Console.ReadLine());
            int caloriesTaken = int.Parse(Console.ReadLine());

            int caloriesBurnedPerMinute = 5;

            int burnedCalories = numWalks * minutesPerWalk * caloriesBurnedPerMinute;
            if (burnedCalories >= caloriesTaken * 0.5)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {burnedCalories}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {burnedCalories}.");
            }
        }
    }
}
