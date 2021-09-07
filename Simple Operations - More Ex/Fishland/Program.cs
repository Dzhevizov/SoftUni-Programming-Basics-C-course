using System;

namespace Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            double mackerelPrice = double.Parse(Console.ReadLine());
            double spratPrice = double.Parse(Console.ReadLine());
            double bonitoWeight = double.Parse(Console.ReadLine());
            double scadWeight = double.Parse(Console.ReadLine());
            int musselsWeight = int.Parse(Console.ReadLine());

            double bonitoPrice = mackerelPrice * 1.6;
            double scadPrice = spratPrice * 1.8;
            double musselsPrice = 7.5;

            double sumBonito = bonitoWeight * bonitoPrice;
            double sumScad = scadWeight * scadPrice;
            double sumMussels = musselsWeight * musselsPrice;

            double totalSum = sumBonito + sumScad + sumMussels;
            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
