using System;

namespace Sleepy_Tom_Cat
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayoffs = int.Parse(Console.ReadLine());
            int workdays = 365 - dayoffs;
            int playtime = workdays * 63 + dayoffs * 127;
            int playNorm = 30000;

            if (playtime > playNorm)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{(playtime - playNorm)/60} hours and {(playtime - playNorm)%60} minutes more for play");
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{(playNorm - playtime) / 60} hours and {(playNorm - playtime) % 60} minutes less for play");
            }
        }
    }
}
