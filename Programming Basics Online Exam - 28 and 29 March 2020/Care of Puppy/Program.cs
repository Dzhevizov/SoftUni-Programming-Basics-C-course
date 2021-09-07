using System;

namespace Care_of_Puppy
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalFood = int.Parse(Console.ReadLine());

            int totalEatenFood = 0;

            string input = Console.ReadLine();

            while (input != "Adopted")
            {
                int eatenFood = int.Parse(input);
                totalEatenFood += eatenFood;

                input = Console.ReadLine();
            }

            totalFood *= 1000;
            if (totalFood >= totalEatenFood)
            {
                Console.WriteLine($"Food is enough! Leftovers: {totalFood - totalEatenFood} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {totalEatenFood - totalFood} grams more.");
            }
        }
    }
    
}
