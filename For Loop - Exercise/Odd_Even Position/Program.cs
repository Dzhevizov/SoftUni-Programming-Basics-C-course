using System;

namespace Odd_Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double oddSum = 0;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;
            double evenSum = 0;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;

            for (int i = 1; i <= n; i++)
            {
                double x = double.Parse(Console.ReadLine());
                if (i % 2 == 1)
                {
                    oddSum += x;
                    if (x < oddMin)
                    {
                        oddMin = x;
                    }
                    if (x > oddMax)
                    {
                        oddMax = x;
                    }
                }
                else
                {
                    evenSum += x;
                    if (x < evenMin)
                    {
                        evenMin = x;
                    }
                    if (x > evenMax)
                    {
                        evenMax = x;
                    }
                }
            }

            Console.WriteLine($"OddSum={oddSum:f2},");
            if (oddMin != double.MaxValue)
            {
                Console.WriteLine($"OddMin={oddMin:f2},");
            }
            else
            {
                Console.WriteLine("OddMin=No,");
            }
            if (oddMax != double.MinValue)
            {
                Console.WriteLine($"OddMax={oddMax:f2},");
            }
            else
            {
                Console.WriteLine("OddMax=No,");
            }
            Console.WriteLine($"EvenSum={evenSum:f2},");
            if (evenMin != double.MaxValue)
            {
                Console.WriteLine($"EvenMin={evenMin:f2},");
            }
            else
            {
                Console.WriteLine("EvenMin=No,");
            }
            if (evenMax != double.MinValue)
            {
                Console.WriteLine($"EvenMax={evenMax:f2}");
            }
            else
            {
                Console.WriteLine("EvenMax=No");
            }
        }
    }
}
