using System;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int n1 = 0, n2 = 0, n3 = 0, n4 = 0, n5 = 0;
            double p1 = 0, p2 = 0, p3 = 0, p4 = 0, p5 = 0;

            for (int i = 1; i <= n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x < 200)
                {
                    n1++;
                }
                else if (x < 400)
                {
                    n2++;
                }
                else if (x < 600)
                {
                    n3++;
                }
                else if (x < 800)
                {
                    n4++;
                }
                else
                {
                    n5++;
                }
            }

            p1 = (double)n1 / n * 100;
            Console.WriteLine($"{p1:f2}%");
            p2 = (double)n2 / n * 100;
            Console.WriteLine($"{p2:f2}%");
            p3 = (double)n3 / n * 100;
            Console.WriteLine($"{p3:f2}%");
            p4 = (double)n4 / n * 100;
            Console.WriteLine($"{p4:f2}%");
            p5 = (double)n5 / n * 100;
            Console.WriteLine($"{p5:f2}%");

        }
    }
}
