using System;

namespace Report_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int targetSum = int.Parse(Console.ReadLine());

            int countTransaction = 0;
            int countCash = 0;
            int countCreditCard = 0;
            int sumCash = 0;
            int sumCreditCard = 0;
            double averageCash = 0;
            double averageCreditCard = 0;

            string input = Console.ReadLine();

            while (input != "End")
            {
                int priceNextProduct = int.Parse(input);
                countTransaction++;
                if (countTransaction % 2 == 1)
                {
                    if (priceNextProduct <= 100)
                    {
                        Console.WriteLine("Product sold!");
                        countCash++;
                        sumCash += priceNextProduct;
                    }
                    else
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                }
                else
                {
                    if (priceNextProduct >= 10)
                    {
                        Console.WriteLine("Product sold!");
                        countCreditCard++;
                        sumCreditCard += priceNextProduct;
                    }
                    else
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                }
                if ((sumCash + sumCreditCard) >= targetSum)
                {
                    break;
                }
                input = Console.ReadLine();
            }

            averageCash = (double)sumCash / countCash;
            averageCreditCard = (double)sumCreditCard / countCreditCard;

            if ((sumCash + sumCreditCard) >= targetSum)
            {
                Console.WriteLine($"Average CS: {averageCash:f2}");
                Console.WriteLine($"Average CC: {averageCreditCard:f2}");
            }
            else
            {
                Console.WriteLine("Failed to collect required money for charity.");
            }
        }
    }
}
