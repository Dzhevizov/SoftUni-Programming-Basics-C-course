using System;

namespace Bike_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            int numJuniors = int.Parse(Console.ReadLine());
            int numSeniors = int.Parse(Console.ReadLine());
            string trace = Console.ReadLine();

            double juniorsTax = 0;
            double seniorsTax = 0;
            double totalSum = 0;

            switch (trace)
            {
                case "trail":
                    juniorsTax = 5.50;
                    seniorsTax = 7.00;
                    break;
                case "cross-country":
                    juniorsTax = 8.00;
                    seniorsTax = 9.50;
                    if ((numSeniors + numJuniors) >= 50)
                    {
                        juniorsTax -= juniorsTax * 0.25;
                        seniorsTax -= seniorsTax * 0.25;
                    }
                    break;
                case "downhill":
                    juniorsTax = 12.25;
                    seniorsTax = 13.75;
                    break;
                case "road":
                    juniorsTax = 20.00;
                    seniorsTax = 21.50;
                    break;
            }

            totalSum = numJuniors * juniorsTax + numSeniors * seniorsTax;
            totalSum -= totalSum * 0.05;

            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
