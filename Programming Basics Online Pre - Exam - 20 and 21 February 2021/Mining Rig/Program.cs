using System;

namespace Mining_Rig
{
    class Program
    {
        static void Main(string[] args)
        {
            int videocardPrice = int.Parse(Console.ReadLine());
            int adapterPrice = int.Parse(Console.ReadLine());
            double electricityPricePerDay = double.Parse(Console.ReadLine());
            double ProfitPerCardPerDay = double.Parse(Console.ReadLine());

            int numVideoCard = 13;
            int numAdapter = 13;
            double otherComponentsPrice = 1000;

            double investment = 0;
            investment = numVideoCard * videocardPrice + numAdapter * adapterPrice + otherComponentsPrice;

            double profitPerDay = 0;
            profitPerDay = numVideoCard * (ProfitPerCardPerDay - electricityPricePerDay);

            double returnOnInvestmentDays = Math.Ceiling(investment / profitPerDay);

            Console.WriteLine(investment);
            Console.WriteLine(returnOnInvestmentDays);
        }
    }
}
