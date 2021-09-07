using System;

namespace Suitcases_Load
{
    class Program
    {
        static void Main(string[] args)
        {
            double luggageCarrier = double.Parse(Console.ReadLine());

            int numSuitcase = 0;

            string input = Console.ReadLine();

            while (input != "End")
            {
                double suitcaseVolume = double.Parse(input);
                numSuitcase++;
                if (numSuitcase % 3 == 0)
                {
                    suitcaseVolume *= 1.10;
                }
                luggageCarrier -= suitcaseVolume;
                if (luggageCarrier < 0)
                {
                    Console.WriteLine("No more space!");
                    numSuitcase--;
                    break;
                }
                input = Console.ReadLine();
            }

            if (luggageCarrier >= 0)
            {
                Console.WriteLine("Congratulations! All suitcases are loaded!");
            }

            Console.WriteLine($"Statistic: {numSuitcase} suitcases loaded.");
        }
    }
}
