using System;

namespace Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numPairs = int.Parse(Console.ReadLine());
            int pairValue = 0;
            int difference = 0;

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            pairValue = a + b;

            for (int n = 1; n < numPairs; n++)
            {
                int a1 = int.Parse(Console.ReadLine());
                int b1 = int.Parse(Console.ReadLine());
                if ((a1 + b1) != pairValue)
                {
                    int difference1 = Math.Abs(a1 + b1 - pairValue);
                    pairValue = a1 + b1;
                    if (difference1 > difference)
                    {
                        difference = difference1;
                    }
                }
            }

            if (difference == 0)
            {
                Console.WriteLine($"Yes, value={pairValue}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={difference}");
            }
            
        }
    }
}
