using System;

namespace Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int hoursNeeded = int.Parse(Console.ReadLine());
            int daysAvailable = int.Parse(Console.ReadLine());
            int numEmployers = int.Parse(Console.ReadLine());
            double workHours = 0.90 * daysAvailable * 8;
            int overtimeHours = 2 * daysAvailable * numEmployers;
            int totalHours = (int)Math.Floor(workHours + overtimeHours);

            if (totalHours >= hoursNeeded)
            {
                Console.WriteLine($"Yes!{totalHours-hoursNeeded} hours left.");
            }
            else
            {
                Console.WriteLine($"Not enough time!{hoursNeeded-totalHours} hours needed.");
            }
        }
    }
}
