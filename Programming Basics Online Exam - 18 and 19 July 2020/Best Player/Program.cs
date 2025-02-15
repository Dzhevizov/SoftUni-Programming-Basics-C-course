﻿using System;

namespace Best_Player
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerName = Console.ReadLine();

            int maxGoals = int.MinValue;
            string bestPlayer = null;

            while (playerName != "END")
            {
                int numGoals = int.Parse(Console.ReadLine());

                if (numGoals > maxGoals)
                {
                    maxGoals = numGoals;
                    bestPlayer = playerName;
                }
                if (numGoals >= 10)
                {
                    break;
                }
                playerName = Console.ReadLine();
            }
            Console.WriteLine($"{bestPlayer} is the best player!");
            if (maxGoals >= 3)
            {
                Console.WriteLine($"He has scored {maxGoals} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {maxGoals} goals.");
            }
        }
    }
}
