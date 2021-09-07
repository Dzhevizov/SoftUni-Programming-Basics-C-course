using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int totalPieces = 0;
            totalPieces = width * length;
            string input = Console.ReadLine();

            while (input != "STOP")
            {
                int takenPieces = int.Parse(input);
                totalPieces -= takenPieces;
                if (totalPieces <= 0)
                {
                    break;
                }
                input = Console.ReadLine();
            }

            if (totalPieces > 0)
            {
                Console.WriteLine($"{totalPieces} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(totalPieces)} pieces more.");
            }
        }
    }
}
