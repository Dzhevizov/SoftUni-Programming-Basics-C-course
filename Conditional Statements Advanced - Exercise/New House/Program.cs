using System;

namespace New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowerType = Console.ReadLine();
            int numFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double flowerPrice = 0;
            double totalPrice = 0;

            switch (flowerType)
            {
                case "Roses":
                    flowerPrice = 5;
                    totalPrice = numFlowers * flowerPrice;
                    if (numFlowers > 80)
                    {
                        totalPrice -= totalPrice * 0.1;
                    }
                    break;
                case "Dahlias":
                    flowerPrice = 3.80;
                    totalPrice = numFlowers * flowerPrice;
                    if (numFlowers > 90)
                    {
                        totalPrice -= totalPrice * 0.15;
                    }
                    break;
                case "Tulips":
                    flowerPrice = 2.80;
                    totalPrice = numFlowers * flowerPrice;
                    if (numFlowers > 80)
                    {
                        totalPrice -= totalPrice * 0.15;
                    }
                    break;
                case "Narcissus":
                    flowerPrice = 3;
                    totalPrice = numFlowers * flowerPrice;
                    if (numFlowers < 120)
                    {
                        totalPrice += totalPrice * 0.15;
                    }
                    break;
                case "Gladiolus":
                    flowerPrice = 2.50;
                    totalPrice = numFlowers * flowerPrice;
                    if (numFlowers < 80)
                    {
                        totalPrice += totalPrice * 0.20;
                    }
                    break;
            }

            if (budget >= totalPrice)
            {
                Console.WriteLine($"Hey, you have a great garden with {numFlowers} {flowerType} and {budget - totalPrice:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {totalPrice - budget:f2} leva more.");
            }
        }
    }
}
