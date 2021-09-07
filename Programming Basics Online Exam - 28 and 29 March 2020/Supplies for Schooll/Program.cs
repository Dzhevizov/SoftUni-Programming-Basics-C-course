using System;

namespace Supplies_for_Schooll
{
    class Program
    {
        static void Main(string[] args)
        {
            int numPens = int.Parse(Console.ReadLine());
            int numMarkers = int.Parse(Console.ReadLine());
            double literDetergent = double.Parse(Console.ReadLine());
            int percentDiscount = int.Parse(Console.ReadLine());

            double penPrice = 5.80;
            double markersPrice = 7.20;
            double detergentPrice = 1.20;

            double totalSum = numPens * penPrice + numMarkers * markersPrice + literDetergent * detergentPrice;
            totalSum -= totalSum * percentDiscount / 100;

            Console.WriteLine($"{totalSum:f3}");


        }
    }
}
