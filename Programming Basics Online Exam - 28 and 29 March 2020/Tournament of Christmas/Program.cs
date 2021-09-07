using System;

namespace Tournament_of_Christmas
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOfTournament = int.Parse(Console.ReadLine());

            double earnedSum = 0;
            int winnerForDay = 0;
            int looserForDay = 0;

            for (int day = 1; day <= daysOfTournament; day++)
            {
                int wins = 0;
                int looses = 0;
                double earnedSumforDay = 0;

                string sport = Console.ReadLine();
                
                while (sport != "Finish")
                {
                    string result = Console.ReadLine();
                    
                    if (result == "win")
                    {
                        earnedSumforDay += 20;
                        wins++;
                    }
                    else
                    {
                        looses++;
                    }
                    sport = Console.ReadLine();
                }
                if (wins > looses)
                {
                    winnerForDay++;
                    earnedSumforDay *= 1.10;
                }
                else
                {
                    looserForDay++;
                }
                earnedSum += earnedSumforDay;
            }

            if (winnerForDay > looserForDay)
            {
                earnedSum *= 1.20;
                Console.WriteLine($"You won the tournament! Total raised money: {earnedSum:f2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {earnedSum:f2}");
            }
        }
    }
}
