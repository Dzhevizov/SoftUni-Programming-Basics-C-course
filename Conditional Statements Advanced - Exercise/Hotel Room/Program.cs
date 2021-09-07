using System;

namespace Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double studioPrice = 0;
            double apartmentPrice = 0;
            double studioTotal = 0;
            double apartmentTotal = 0;

            switch (month)
            {
                case "May":
                case "October":
                    studioPrice = 50;
                    apartmentPrice = 65;
                    if (nights > 14)
                    {
                        studioPrice -= studioPrice * 0.3;
                    }
                    else if (nights > 7)
                    {
                        studioPrice -= studioPrice * 0.05;
                    }
                    break;
                case "June":
                case "September":
                    studioPrice = 75.20;
                    apartmentPrice = 68.70;
                    if (nights > 14)
                    {
                        studioPrice -= studioPrice * 0.2;
                    }
                    break;
                case "July":
                case "August":
                    studioPrice = 76;
                    apartmentPrice = 77;
                    break;
            }

            if (nights > 14)
            {
                apartmentPrice -= apartmentPrice * 0.1;
            }

            studioTotal = studioPrice * nights;
            apartmentTotal = apartmentPrice * nights;

            Console.WriteLine($"Apartment: {apartmentTotal:f2} lv.");
            Console.WriteLine($"Studio: {studioTotal:f2} lv.");
        }
    }
}
