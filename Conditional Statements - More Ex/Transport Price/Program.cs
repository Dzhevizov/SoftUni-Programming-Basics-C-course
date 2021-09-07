using System;

namespace Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            string partOfTheDay = Console.ReadLine();

            if (distance >= 100)
            {
                Console.WriteLine($"{distance * 0.06:f2}");
            }
            else if (distance >= 20)
            {
                Console.WriteLine($"{distance * 0.09:f2}");
            }
            else
            {
                if (partOfTheDay == "day")
                {
                    Console.WriteLine($"{0.70 + 0.79 * distance:f2}");
                }
                else if (partOfTheDay == "night")
                {
                    Console.WriteLine($"{0.70 + 0.90 * distance:f2}");
                }
            }
        }
    }
}
