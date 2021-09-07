using System;

namespace Trekking_Mania
{
    class Program
    {
        static void Main(string[] args)
        {
            int numGroups = int.Parse(Console.ReadLine());

            int mussalaClimbers = 0;
            int monblanClimbers = 0;
            int kilimandjaroClimbers = 0;
            int k2Climbers = 0;
            int everestClimbers = 0;
            int totalClimbers = 0;

            for (int currGroup = 1; currGroup <= numGroups; currGroup++)
            {
                int groupSize = int.Parse(Console.ReadLine());
                totalClimbers += groupSize;

                if (groupSize <= 5)
                {
                    mussalaClimbers += groupSize;
                }
                else if (groupSize <= 12)
                {
                    monblanClimbers += groupSize;
                }
                else if (groupSize <= 25)
                {
                    kilimandjaroClimbers += groupSize;
                }
                else if (groupSize <= 40)
                {
                    k2Climbers += groupSize;
                }
                else
                {
                    everestClimbers += groupSize;
                }
            }

            double percentMussalaClimbers = (double)mussalaClimbers / totalClimbers * 100;
            double percentMonblanClimbers = (double)monblanClimbers / totalClimbers * 100;
            double percentKilimandjaroClimbers = (double)kilimandjaroClimbers / totalClimbers * 100;
            double percentK2Climbers = (double)k2Climbers / totalClimbers * 100;
            double percentEverestClimbers = (double)everestClimbers / totalClimbers * 100;

            Console.WriteLine($"{percentMussalaClimbers:f2}%");
            Console.WriteLine($"{percentMonblanClimbers:f2}%");
            Console.WriteLine($"{percentKilimandjaroClimbers:f2}%");
            Console.WriteLine($"{percentK2Climbers:f2}%");
            Console.WriteLine($"{percentEverestClimbers:f2}%");
        }
    }
}
