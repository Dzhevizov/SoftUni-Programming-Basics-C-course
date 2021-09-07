using System;

namespace Food_for_Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double totalFood = double.Parse(Console.ReadLine());

            double foodEatenByDogTotal = 0;
            double foodEatenByCatTotal = 0;
            double totalEatenBiscuits = 0;

            for (int currDay = 1; currDay <= days; currDay++)
            {
                double foodEatenByDog = double.Parse(Console.ReadLine());
                double foodEatenByCat = double.Parse(Console.ReadLine());

                foodEatenByDogTotal += foodEatenByDog;
                foodEatenByCatTotal += foodEatenByCat;

                if (currDay % 3 == 0)
                {
                    totalEatenBiscuits += (foodEatenByDog + foodEatenByCat) * 0.10;
                }
            }

            double eatenFoodTotal = foodEatenByDogTotal + foodEatenByCatTotal;
            double percentEatenFood = eatenFoodTotal / totalFood * 100;
            double percentEatenFoodByDog = foodEatenByDogTotal / eatenFoodTotal * 100;
            double percentEatenFoodByCat = foodEatenByCatTotal / eatenFoodTotal * 100;

            Console.WriteLine($"Total eaten biscuits: {Math.Round(totalEatenBiscuits)}gr.");
            Console.WriteLine($"{percentEatenFood:f2}% of the food has been eaten.");
            Console.WriteLine($"{percentEatenFoodByDog:f2}% eaten from the dog.");
            Console.WriteLine($"{percentEatenFoodByCat:f2}% eaten from the cat.");
        }
    }
}
