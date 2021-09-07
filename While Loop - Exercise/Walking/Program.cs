using System;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int targetSteps = 10000;
            string input = Console.ReadLine();
            int steps = 0;
            int totalSteps = 0;

            while (input != "Going home")
            {
                steps = int.Parse(input);
                totalSteps += steps;

                if (totalSteps >= targetSteps)
                {
                    break;
                }

                input = Console.ReadLine();
            }
            if(input == "Going home")
            {
                steps = int.Parse(Console.ReadLine());
                totalSteps += steps;
            }
            if (totalSteps >= targetSteps)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{totalSteps - targetSteps} steps over the goal!");
            }
            if (totalSteps < targetSteps)
            {
                Console.WriteLine($"{targetSteps - totalSteps} more steps to reach goal.");
            }
        }
    }
}
