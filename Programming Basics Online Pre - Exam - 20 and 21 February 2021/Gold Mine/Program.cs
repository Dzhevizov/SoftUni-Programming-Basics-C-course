using System;

namespace Gold_Mine
{
    class Program
    {
        static void Main(string[] args)
        {
            int numLocations = int.Parse(Console.ReadLine());

            for (int currLocation = 1; currLocation <= numLocations; currLocation++)
            {
                double expectedOutput = double.Parse(Console.ReadLine());
                int diggingDays = int.Parse(Console.ReadLine());

                double sumOutput = 0;
                double averageOutput = 0;

                for (int currDay = 1; currDay <= diggingDays; currDay++)
                {
                    double outputForTheDay = double.Parse(Console.ReadLine());
                    sumOutput += outputForTheDay;
                }

                averageOutput = sumOutput / diggingDays;

                if (averageOutput >= expectedOutput)
                {
                    Console.WriteLine($"Good job! Average gold per day: {averageOutput:f2}.");
                }
                else
                {
                    Console.WriteLine($"You need {expectedOutput - averageOutput:f2} gold.");
                }
            }
        }
    }
}
