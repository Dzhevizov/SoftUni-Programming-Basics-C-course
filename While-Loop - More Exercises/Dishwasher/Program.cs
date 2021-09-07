using System;

namespace Dishwasher
{
    class Program
    {
        static void Main(string[] args)
        {
            int numBottlesOfDetergent = int.Parse(Console.ReadLine());
            int detergent = numBottlesOfDetergent * 750;
            int numDishes = 0;
            int numPots = 0;
            int counterInput = 0;
            string input = Console.ReadLine();

            while (input != "End")
            {
                int Utilities = int.Parse(input);
                counterInput++;
                if (counterInput % 3 == 0)
                {
                    numPots += Utilities;
                    detergent -= Utilities * 15;
                }
                else
                {
                    numDishes += Utilities;
                    detergent -= Utilities * 5;
                }
                if (detergent < 0)
                {
                    break;
                }
                    input = Console.ReadLine();
            }

            if (detergent >= 0)
            {
                Console.WriteLine("Detergent was enough!");
                Console.WriteLine($"{numDishes} dishes and {numPots} pots were washed.");
                Console.WriteLine($"Leftover detergent {detergent} ml.");
            }
            else
            {
                Console.WriteLine($"Not enough detergent, {Math.Abs(detergent)} ml. more necessary!");
            }
        }
    }
}
