using System;

namespace Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;

            for (int i = 1; i <= 9; i++)
            {
                if (N % i == 0)
                {
                    num1 = i;
                    for (int j = 1; j <= 9; j++)
                    {
                        if (N % j == 0)
                        {
                            num2 = j;
                            for (int k = 1; k <= 9; k++)
                            {
                                if (N % k == 0)
                                {
                                    num3 = k;
                                    for (int l = 1; l <= 9; l++)
                                    {
                                        if (N % l == 0)
                                        {
                                            num4 = l;
                                            Console.Write($"{num1}{num2}{num3}{num4} ");
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            Console.Write("\n");
        }
    }
}
