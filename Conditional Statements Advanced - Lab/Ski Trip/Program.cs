using System;

namespace Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string feedback = Console.ReadLine();

            int nights = days - 1; 
            double pricePerNight = 0;
            double discount = 0;
            double totalPrice = 0;

            switch (roomType)
            {
                case "apartment":
                    pricePerNight = 25;
                    if (days < 10)
                    {
                        discount = 0.3;
                        totalPrice = nights * pricePerNight * (1 - discount);
                    }
                    else if (days > 15)
                    {
                        discount = 0.5;
                        totalPrice = nights * pricePerNight * (1 - discount);
                    }
                    else
                    {
                        discount = 0.35;
                        totalPrice = nights * pricePerNight * (1 - discount);
                    }
                    break;
                case "president apartment":
                    pricePerNight = 35;
                    if (days < 10)
                    {
                        discount = 0.1;
                        totalPrice = nights * pricePerNight * (1 - discount);
                    }
                    else if (days > 15)
                    {
                        discount = 0.2;
                        totalPrice = nights * pricePerNight * (1 - discount);
                    }
                    else
                    {
                        discount = 0.15;
                        totalPrice = nights * pricePerNight * (1 - discount);
                    }
                    break;
                case "room for one person":
                    pricePerNight = 18;
                    totalPrice = nights * pricePerNight;
                    break;

            }

            switch (feedback)
            {
                case "positive":
                    totalPrice += totalPrice * 0.25; 
                    break;
                case "negative":
                    totalPrice -= totalPrice * 0.10;
                    break;
            }

            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
