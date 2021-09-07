using System;

namespace Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int symbol1 = 0;
            int symbol2 = 0;
            char symbol3 = '\0';
            char symbol4 = '\0';
            int symbol5 = 0;

            for (int i = 1; i < n; i++)
            {
                symbol1 = i;
                for (int j = 1; j < n; j++)
                {
                    symbol2 = j;
                    for (int k = 0; k < l; k++)
                    {
                        symbol3 = (char)('a' + k);
                        for (int m = 0; m < l; m++)
                        {
                            symbol4 = (char)('a' + m);
                            for (int x = 2; x <= n; x++)
                            {
                                if (x > symbol1 && x > symbol2)
                                {
                                    symbol5 = x;
                                    Console.Write($"{symbol1}{symbol2}{symbol3}{symbol4}{symbol5} ");
                                }
                            }
                        } 
                    }
                } 
            }

            Console.WriteLine("\n");
        }
    }
}
