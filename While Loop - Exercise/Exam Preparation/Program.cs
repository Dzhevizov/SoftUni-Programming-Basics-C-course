using System;

namespace Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int failsLimit = int.Parse(Console.ReadLine());
            string nextTask = Console.ReadLine();
            int tasks = 0;
            int fails = 0;
            int totalMarks = 0;
            double averageMarks = 0;
            string lastTask = null;

            while (nextTask != "Enough")
            {
                int mark = int.Parse(Console.ReadLine());
                
                if (mark <= 4)
                {
                    fails++;
                }
                if (fails == failsLimit)
                {
                    Console.WriteLine($"You need a break, {fails} poor grades.");
                    break;
                }

                tasks++;
                lastTask = nextTask;
                totalMarks += mark;

                nextTask = Console.ReadLine();
            }

            averageMarks = (double)totalMarks / tasks;

            if (fails < failsLimit)
            {
                Console.WriteLine($"Average score: {averageMarks:f2}");
                Console.WriteLine($"Number of problems: {tasks}");
                Console.WriteLine($"Last problem: {lastTask}");
            }
        }
    }
}
