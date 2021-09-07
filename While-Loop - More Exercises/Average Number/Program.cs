using System;

namespace Average_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            double average = 0;

            for (int i = 1; i <= n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                sum += x;
            }
            average = (double)sum / n;
            Console.WriteLine($"{average:f2}");
        }
    }
}
