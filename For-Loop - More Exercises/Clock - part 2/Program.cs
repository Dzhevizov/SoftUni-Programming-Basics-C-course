using System;

namespace Clock___part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = 0;
            int minutes = 0;
            int seconds = 0;

            for (int sec = 0; sec < 86400; sec++)
            {
                int mins = sec / 60;
                seconds = sec % 60;
                minutes = mins % 60;
                hours = mins / 60;
                Console.WriteLine($"{hours} : {minutes} : {seconds} ");
            }
        }
    }
}
