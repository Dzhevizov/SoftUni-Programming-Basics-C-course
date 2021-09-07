using System;

namespace Godzila_vs_Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numStatist = int.Parse(Console.ReadLine());
            double priceClothes = double.Parse(Console.ReadLine());

            double dekor = budget * 0.1;
            double sumClothes = numStatist * priceClothes;

            if (numStatist > 150)
            {
                sumClothes -= sumClothes * 0.1;
            }

            double ekspenses = dekor + sumClothes;

            if (ekspenses > budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {ekspenses-budget:f2} leva more." );
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget-ekspenses:f2} leva left.");
            }
        }
    }
}
