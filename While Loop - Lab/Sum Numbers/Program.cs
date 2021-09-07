using System;

namespace Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int sum = 0;
            int num = int.Parse(Console.ReadLine());
            sum += num;

            while (sum < num1)
            {
                num = int.Parse(Console.ReadLine());
                sum += num;
            }

            Console.WriteLine(sum);
        }
    }
}
