using System;

namespace Number_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            int min = int.MaxValue;

            for (int i = 1; i <= n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x > max)
                {
                    max = x;
                }
                if (x < min)
                {
                    min = x;
                }
            }

            Console.WriteLine($"Max number: {max}");
            Console.WriteLine($"Min number: {min}");
        }
    }
}
