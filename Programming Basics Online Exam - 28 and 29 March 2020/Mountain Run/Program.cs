using System;

namespace Mountain_Run
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double secondsPerMeter = double.Parse(Console.ReadLine());

            double currentTime = distance * secondsPerMeter;
            double delay = Math.Floor(distance / 50) * 30;
            currentTime += delay;

            if (currentTime < record)
            {
                Console.WriteLine($"Yes! The new record is {currentTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No! He was {currentTime - record:f2} seconds slower.");
            }
        }
    }
}
