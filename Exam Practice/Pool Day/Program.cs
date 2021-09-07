using System;

namespace Pool_Day
{
    class Program
    {
        static void Main(string[] args)
        {
            int numPeople = int.Parse(Console.ReadLine());
            double taxEntrance = double.Parse(Console.ReadLine());
            double shezlongPrice = double.Parse(Console.ReadLine());
            double umbrelaPrice = double.Parse(Console.ReadLine());

            double numUmbrela = 0;
            numUmbrela = Math.Ceiling(numPeople * 0.50); ;
            double numShezlong = 0;
            numShezlong = Math.Ceiling(numPeople * 0.75);

            double totalCosts = 0;
            totalCosts = numPeople * taxEntrance + numShezlong * shezlongPrice + numUmbrela * umbrelaPrice;

            Console.WriteLine($"{totalCosts:f2} lv.");
        }
    }
}
