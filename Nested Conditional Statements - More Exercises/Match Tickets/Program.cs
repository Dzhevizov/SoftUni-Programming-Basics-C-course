using System;

namespace Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int numPeople = int.Parse(Console.ReadLine());

            double vipPrice = 499.99;
            double normalPrice = 249.99;
            double totalPrice = 0;

            if (numPeople >= 1 && numPeople <= 4)
            {
                budget -= budget * 0.75;
            }
            else if (numPeople >= 5 && numPeople <= 9)
            {
                budget -= budget * 0.60;
            }
            else if (numPeople >= 10 && numPeople <= 24)
            {
                budget -= budget * 0.50;
            }
            else if (numPeople >= 25 && numPeople <= 49)
            {
                budget -= budget * 0.40;
            }
            else if (numPeople > 50)
            {
                budget -= budget * 0.25;
            }

            if (category == "VIP")
            {
                totalPrice = numPeople * vipPrice;
            }
            else if (category == "Normal")
            {
                totalPrice = numPeople * normalPrice;
            }

            if (budget >= totalPrice)
            {
                Console.WriteLine($"Yes! You have {budget - totalPrice :f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {totalPrice - budget :f2} leva.");
            }

        }
    }
}
