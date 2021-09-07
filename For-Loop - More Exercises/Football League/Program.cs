using System;

namespace Football_League
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            int totalFans = int.Parse(Console.ReadLine());

            int numFansSectorA = 0;
            int numFansSectorB = 0;
            int numFansSectorV = 0;
            int numFansSectorG = 0;

            double percentFansSectorA = 0;
            double percentFansSectorB = 0;
            double percentFansSectorV = 0;
            double percentFansSectorG = 0;
            double percentSoldOut = 0;

            for (int nextFan = 1; nextFan <= totalFans; nextFan++)
            {
                string sector = Console.ReadLine();

                switch (sector)
                {
                    case "A":
                        numFansSectorA++;
                        break;
                    case "B":
                        numFansSectorB++;
                        break;
                    case "V":
                        numFansSectorV++;
                        break;
                    case "G":
                        numFansSectorG++;
                        break;
                }

            }

            percentFansSectorA = (double)numFansSectorA * 100 / totalFans;
            percentFansSectorB = (double)numFansSectorB * 100 / totalFans;
            percentFansSectorV = (double)numFansSectorV * 100 / totalFans;
            percentFansSectorG = (double)numFansSectorG * 100 / totalFans;
            percentSoldOut = (double)totalFans * 100 / capacity;

            Console.WriteLine($"{percentFansSectorA:f2}%");
            Console.WriteLine($"{percentFansSectorB:f2}%");
            Console.WriteLine($"{percentFansSectorV:f2}%");
            Console.WriteLine($"{percentFansSectorG:f2}%");
            Console.WriteLine($"{percentSoldOut:f2}%");
        }
    }
}
