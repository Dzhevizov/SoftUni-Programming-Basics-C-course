using System;

namespace Flower_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int numMagnolias = int.Parse(Console.ReadLine());
            int numHyacinths = int.Parse(Console.ReadLine());
            int numRoses = int.Parse(Console.ReadLine());
            int numCacti = int.Parse(Console.ReadLine());
            double giftPrice = double.Parse(Console.ReadLine());
            double totalMoney = numMagnolias * 3.25 + numHyacinths * 4 + numRoses * 3.5 + numCacti * 8;
            totalMoney -= 0.05 * totalMoney;

            if (totalMoney >= giftPrice)
            {
                Console.WriteLine($"She is left with {Math.Floor(totalMoney - giftPrice)} leva.");
            }
            else
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(giftPrice - totalMoney)} leva.");
            }
        }
    }
}
