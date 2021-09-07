using System;

namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numVideoCards = int.Parse(Console.ReadLine());
            int numProcessors = int.Parse(Console.ReadLine());
            int numRAMmemory = int.Parse(Console.ReadLine());

            double videoCardsPrice = 250;
            double videoCardsTotalPrice = numVideoCards * videoCardsPrice;
            double processorPrice = videoCardsTotalPrice * 0.35;
            double ramMemoryPrice = videoCardsTotalPrice * 0.10;

            double totalPrice = videoCardsTotalPrice + numProcessors * processorPrice + numRAMmemory * ramMemoryPrice;

            if (numVideoCards > numProcessors)
            {
                totalPrice *= 0.85;
            }

            if (budget >= totalPrice)
            {
                Console.WriteLine($"You have {budget - totalPrice:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {totalPrice - budget:f2} leva more!");
            }

        }
    }
}
