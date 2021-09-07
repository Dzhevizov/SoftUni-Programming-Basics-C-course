using System;

namespace Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            double savedSum = 0;

            while (destination != "End")
            {
                double budget = double.Parse(Console.ReadLine());
                double savedMoney = double.Parse(Console.ReadLine());
                savedSum += savedMoney;

                while (savedSum < budget)
                {
                    savedMoney = double.Parse(Console.ReadLine());
                    savedSum += savedMoney;
                }
                Console.WriteLine($"Going to {destination}!");
                savedSum = 0;
                destination = Console.ReadLine();
            }
        }
    }
}
