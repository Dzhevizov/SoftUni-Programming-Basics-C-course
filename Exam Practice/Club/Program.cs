using System;

namespace Club
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	На първия ред – желаната печалба на клуба -реално число в интервала[1.00... 15000.00]
            //Поредица от два реда до получаване на командата "Party!" или до достигане на желаната печалба:
            //    o Име на коктейла – текст
            //    o Брой на коктейлите за поръчката – цяло число в интервала[1… 50]

            double targetProfit = double.Parse(Console.ReadLine());
            string coctailType = Console.ReadLine();

            double realProfit = 0;

            while (coctailType != "Party!")
            {
                int numCoctails = int.Parse(Console.ReadLine());

                double coctailPrice = 0;
                double orderPrice = 0;

                coctailPrice = coctailType.Length;
                orderPrice = numCoctails * coctailPrice;

                if (orderPrice % 2 == 1)
                {
                    orderPrice *= 0.75;
                }

                realProfit += orderPrice;

                if (realProfit >= targetProfit)
                {
                    Console.WriteLine("Target acquired.");
                    Console.WriteLine($"Club income - {realProfit:f2} leva.");
                    return;
                }

                coctailType = Console.ReadLine();
            }

            Console.WriteLine($"We need {targetProfit - realProfit:f2} leva more.");
            Console.WriteLine($"Club income - {realProfit:f2} leva.");

        }
    }
}
