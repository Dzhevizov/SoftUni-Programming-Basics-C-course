using System;

namespace Easter_Competition
{
    class Program
    {
        static void Main(string[] args)
        {
            int numEasterBread = int.Parse(Console.ReadLine());

            int bestScore = 0;
            string bestBaker = null;

            for (int currEasterBread = 1; currEasterBread <= numEasterBread; currEasterBread++)
            {
                string nameBaker = Console.ReadLine();
                string input = Console.ReadLine();
                int totalscore = 0;

                while (input != "Stop")
                {
                    int mark = int.Parse(input);
                    totalscore += mark;
                    input = Console.ReadLine();
                }

                Console.WriteLine($"{nameBaker} has {totalscore} points.");

                if (totalscore > bestScore)
                {
                    Console.WriteLine($"{nameBaker} is the new number 1!");
                    bestBaker = nameBaker;
                    bestScore = totalscore;
                }
            }

            Console.WriteLine($"{bestBaker} won competition with {bestScore} points!");
        }
    }
}
