using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double availableMoney = double.Parse(Console.ReadLine());
            int spendingDays = 0;
            int totalDays = 0;

            while (availableMoney < neededMoney)
            {
                string action = Console.ReadLine();
                double sum = double.Parse(Console.ReadLine());
                totalDays++;
                if (action == "spend")
                {
                    if (availableMoney < sum)
                    {
                        availableMoney = 0;
                    }
                    else
                    {
                        availableMoney -= sum;
                    }
                    spendingDays++;
                }
                else if (action == "save")
                {
                    availableMoney += sum;
                    spendingDays = 0;
                }
                if (spendingDays == 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine($"{totalDays}");
                    break;
                }
            }

            if (spendingDays < 5)
            {
                Console.WriteLine($"You saved the money for {totalDays} days.");
            }
        }
    }
}
