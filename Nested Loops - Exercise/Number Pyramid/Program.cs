using System;

namespace Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            bool isNumber = false;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    count++;
                    Console.Write($"{count} ");
                    if (count == n)
                    {
                        isNumber = true;
                        break;
                    }
                }

                Console.Write("\n");
                if (isNumber)
                {
                    break;
                }
            }
        }
    }
}
