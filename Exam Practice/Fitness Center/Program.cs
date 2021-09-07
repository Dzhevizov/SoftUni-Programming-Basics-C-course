using System;

namespace Fitness_Center
{
    class Program
    {
        static void Main(string[] args)
        {
            int visitors = int.Parse(Console.ReadLine());

            int countBacktrainers = 0;
            int countChesttrainers = 0;
            int countLegstrainers = 0;
            int countAbstrainers = 0;
            int countProteinShakebuyers = 0;
            int countProteinBarbuyers = 0;

            double percentTrainers = 0;
            double percentBuyers = 0;

            for (int currVisitor = 1; currVisitor <= visitors; currVisitor++)
            {
                string activity = Console.ReadLine();
                switch (activity)
                {
                    case "Back":
                        countBacktrainers++;
                        break;
                    case "Chest":
                        countChesttrainers++;
                        break;
                    case "Legs":
                        countLegstrainers++;
                        break;
                    case "Abs":
                        countAbstrainers++;
                        break;
                    case "Protein shake":
                        countProteinShakebuyers++;
                        break;
                    case "Protein bar":
                        countProteinBarbuyers++;
                        break;
                }
            }

            percentTrainers = (double)(countBacktrainers + countChesttrainers + countLegstrainers + countAbstrainers) / visitors * 100;
            percentBuyers = (double)(countProteinShakebuyers + countProteinBarbuyers) / visitors * 100;

            Console.WriteLine($"{countBacktrainers} - back");
            Console.WriteLine($"{countChesttrainers} - chest");
            Console.WriteLine($"{countLegstrainers} - legs");
            Console.WriteLine($"{countAbstrainers} - abs");
            Console.WriteLine($"{countProteinShakebuyers} - protein shake");
            Console.WriteLine($"{countProteinBarbuyers} - protein bar");
            Console.WriteLine($"{percentTrainers:f2}% - work out");
            Console.WriteLine($"{percentBuyers:f2}% - protein");
        }
    }
}
