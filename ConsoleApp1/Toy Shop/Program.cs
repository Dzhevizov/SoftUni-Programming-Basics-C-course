using System;

namespace Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            const double puzzlePrice = 2.60;
            const double dollPrice = 3.00;
            const double bearPrice = 4.10;
            const double minionPrice = 8.20;
            const double truckPrice = 2.00;

            double holidayPrice = double.Parse(Console.ReadLine());
            int puzzleNum = int.Parse(Console.ReadLine());
            int dollNum = int.Parse(Console.ReadLine());
            int bearNum = int.Parse(Console.ReadLine());
            int minionNum = int.Parse(Console.ReadLine());
            int truckNum = int.Parse(Console.ReadLine());

            double puzzleSum = puzzleNum * puzzlePrice;
            double dollSum = dollNum * dollPrice;
            double bearSum = bearNum * bearPrice;
            double minionSum = minionNum * minionPrice;
            double truckSum = truckNum * truckPrice;

            double totalSum = puzzleSum + dollSum + bearSum + minionSum + truckSum;
            int toysNum = puzzleNum + dollNum + bearNum + minionNum + truckNum;
            
            if (toysNum >= 50)
            {
                totalSum -= totalSum * 0.25;
            }

            totalSum -= totalSum * 0.10;

            if (totalSum >= holidayPrice)
            {
                Console.WriteLine($"Yes! {totalSum - holidayPrice:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {holidayPrice - totalSum:f2} lv needed.");
            }
        }
    }
}
