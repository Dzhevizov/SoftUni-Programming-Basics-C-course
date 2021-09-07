using System;

namespace Swimming_World_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double oldRecord = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timePerMeter = double.Parse(Console.ReadLine());

            int breakpoints = (int)Math.Floor(distance / 15);
            double resistance = breakpoints * 12.5;
            double totalTime = distance * timePerMeter + resistance;

            if (totalTime < oldRecord)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {totalTime-oldRecord:f2} seconds slower.");
            }
        }
    }
}
