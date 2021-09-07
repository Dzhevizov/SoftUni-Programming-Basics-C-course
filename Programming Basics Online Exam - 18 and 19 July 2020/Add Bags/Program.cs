using System;

namespace Add_Bags
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceOverTwentyKilos = double.Parse(Console.ReadLine());
            double luggageKilos = double.Parse(Console.ReadLine());
            int daysToTravel = int.Parse(Console.ReadLine());
            int numLuggage = int.Parse(Console.ReadLine());

            double luggagePrice = 0;
            double totalPrice = 0;

            if (luggageKilos < 10)
            {
                luggagePrice = priceOverTwentyKilos * 0.20;
            }
            else if (luggageKilos <= 20)
            {
                luggagePrice = priceOverTwentyKilos * 0.50;
            }
            else
            {
                luggagePrice = priceOverTwentyKilos;
            }

            if (daysToTravel > 30)
            {
                luggagePrice *= 1.10;
            }
            else if (daysToTravel >= 7)
            {
                luggagePrice *= 1.15;
            }
            else
            {
                luggagePrice *= 1.40;
            }

            totalPrice = numLuggage * luggagePrice;
            Console.WriteLine($"The total price of bags is: {totalPrice:f2} lv. ");
        }
    }
}
