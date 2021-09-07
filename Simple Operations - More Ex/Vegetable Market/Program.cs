using System;

namespace Vegetable_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double vegetablesPrice = double.Parse(Console.ReadLine());
            double fruitsPrice = double.Parse(Console.ReadLine());
            int vegetablesWeight = int.Parse(Console.ReadLine());
            int fruitsWeight = int.Parse(Console.ReadLine());

            double incomeInLeva = vegetablesWeight * vegetablesPrice + fruitsWeight * fruitsPrice;
            double incomeInEuro = incomeInLeva / 1.94;

            Console.WriteLine($"{incomeInEuro:f2}");
        
        }
            
    }
}

