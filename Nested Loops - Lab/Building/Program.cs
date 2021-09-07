using System;

namespace Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int level = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());

            for (int l = level; l >= 1; l--)
            {
                for (int r = 0; r < rooms; r++)
                {
                    if (l == level)
                    {
                        Console.Write($"L{l}{r} ");
                    }
                    else if ((l % 2) == 1)
                    {
                        Console.Write($"A{l}{r} ");
                    }
                    else
                    {
                        Console.Write($"O{l}{r} ");
                    }
                }
                Console.Write("\n");
                
            }
        }
    }
}
