using System;

namespace Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum1 = 0;
            int sum2 = 0;

            for (int i = 1; i <= n; i++)
            {
                int x1 = int.Parse(Console.ReadLine());
                sum1 += x1;
            }

            for (int i = 1; i <= n; i++)
            {
                int x2 = int.Parse(Console.ReadLine());
                sum2 += x2;
            }

            if (sum1 == sum2)
            {
                Console.WriteLine($"Yes, sum = {sum1}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(sum1-sum2)}");
            }
        }
    }
}
