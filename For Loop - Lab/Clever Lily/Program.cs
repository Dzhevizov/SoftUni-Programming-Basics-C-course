using System;

namespace Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceWashingMachine = double.Parse(Console.ReadLine());
            double priceToys = double.Parse(Console.ReadLine());

            int numToys = 0;
            double moneyGift = 0;
            int evenBirthdaysCounter = 0;
            double moneyToys = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 1)
                {
                    numToys++;
                }
                else
                {
                    evenBirthdaysCounter++;
                    moneyGift += evenBirthdaysCounter * 10;
                    moneyGift--;
                }
            }

            moneyToys = numToys * priceToys;
            moneyGift += moneyToys;

            if (moneyGift >= priceWashingMachine)
            {
                Console.WriteLine($"Yes! {moneyGift-priceWashingMachine:f2}");
            }
            else
            {
                Console.WriteLine($"No! {priceWashingMachine-moneyGift:f2}");
            }
        }
    }
}
