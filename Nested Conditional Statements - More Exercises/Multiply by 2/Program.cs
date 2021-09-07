using System;

namespace Multiply_by_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = 0;
            begin:
            num = double.Parse(Console.ReadLine());
            if (num >= 0)
            {      
                num *= 2;
                Console.WriteLine($"Result: {num:f2}");
                goto begin;
            }

            if (num < 0)
            {
                Console.WriteLine("Negative number!");
            }

        }
    }
}
