using System;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string yearType = Console.ReadLine();
            double holidays = double.Parse(Console.ReadLine());
            double weekendsInHometown = double.Parse(Console.ReadLine());

            double weekendsInSofia = 48 - weekendsInHometown;
            double volleybalNum = 3 * weekendsInSofia / 4 + weekendsInHometown;
            volleybalNum += 2 * holidays / 3;
            if (yearType == "leap")
            {
                volleybalNum += volleybalNum * 0.15;
            }

            Console.WriteLine($"{Math.Floor(volleybalNum)}");
        }
    }
}
