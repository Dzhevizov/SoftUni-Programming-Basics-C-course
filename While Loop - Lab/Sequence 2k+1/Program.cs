using System;

namespace Sequence_2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int p = 0;
            p = 2 * p + 1;

            while (p <= n)
            {
                Console.WriteLine(p);
                p = 2 * p + 1;
            }
        }
    }
}
