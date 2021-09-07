using System;

namespace Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutes = 0;
            int hours = 0;

            for (int min = 0; min < 1440; min++)
            {
                hours = min / 60;
                minutes = min % 60;
                Console.WriteLine($"{hours} : {minutes}");
            }
        }
    }
}
