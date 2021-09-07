using System;

namespace Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            int numMonths = int.Parse(Console.ReadLine());

            double billWater = 20;
            double billInternet = 15;
            double percentOthersPerMonth = 1.20;

            double sumElectricity = 0;
            double sumWater = 0;
            double sumInternet = 0;
            double sumOtherCosts = 0;
            double averageCosts = 0;

            for (int nextMonth = 1; nextMonth <= numMonths; nextMonth++)
            {
                double billElectricity = double.Parse(Console.ReadLine());
                sumElectricity += billElectricity;
                sumWater += billWater;
                sumInternet += billInternet;
                sumOtherCosts += (billElectricity + billWater + billInternet) * percentOthersPerMonth;
            }

            averageCosts = (sumElectricity + sumWater + sumInternet + sumOtherCosts) / numMonths;

            Console.WriteLine($"Electricity: {sumElectricity:f2} lv");
            Console.WriteLine($"Water: {sumWater:f2} lv");
            Console.WriteLine($"Internet: {sumInternet:f2} lv");
            Console.WriteLine($"Other: {sumOtherCosts:f2} lv");
            Console.WriteLine($"Average: {averageCosts:f2} lv");
        }
    }
}
