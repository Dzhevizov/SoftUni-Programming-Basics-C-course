using System;

namespace Divide_Without_Remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int n1 = 0, n2 = 0, n3 = 0;
            double p1 = 0, p2 = 0, p3 = 0;

            for (int i = 1; i <= n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x % 2 == 0)
                {
                    n1++;
                }
                if (x % 3 == 0)
                {
                    n2++;
                }
                if (x % 4 == 0)
                {
                    n3++;
                }
            }

            p1 = (double)n1 / n * 100;
            Console.WriteLine($"{p1:f2}%");
            p2 = (double)n2 / n * 100;
            Console.WriteLine($"{p2:f2}%");
            p3 = (double)n3 / n * 100;
            Console.WriteLine($"{p3:f2}%");
        }
    }
}
