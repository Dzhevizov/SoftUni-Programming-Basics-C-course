using System;

namespace School_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Сезонът – текст - “Winter”, “Spring” или “Summer”;
            //2.Видът на групата – текст - “boys”, “girls” или “mixed”;
            //3.Брой на учениците – цяло число в интервала[1 … 10000];
            //4.Брой на нощувките – цяло число в интервала[1 … 100].

            string season = Console.ReadLine();
            string groupType = Console.ReadLine();
            int numStudents = int.Parse(Console.ReadLine());
            int numNights = int.Parse(Console.ReadLine());

            string sportType = null;
            double pricePerNight = 0;
            double totalPrice = 0;

            switch (season)
            {
                case "Winter":
                    switch (groupType)
                    {
                        case "girls":
                            sportType = "Gymnastics";
                            pricePerNight = 9.60;
                            break;
                        case "boys":
                            sportType = "Judo";
                            pricePerNight = 9.60;
                            break;
                        case "mixed":
                            sportType = "Ski";
                            pricePerNight = 10;
                            break;
                    }
                    break;
                case "Spring":
                    switch (groupType)
                    {
                        case "girls":
                            sportType = "Athletics";
                            pricePerNight = 7.20;
                            break;
                        case "boys":
                            sportType = "Tennis";
                            pricePerNight = 7.20;
                            break;
                        case "mixed":
                            sportType = "Cycling";
                            pricePerNight = 9.50;
                            break;
                    }
                    break;
                case "Summer":
                    switch (groupType)
                    {
                        case "girls":
                            sportType = "Volleyball";
                            pricePerNight = 15.00;
                            break;
                        case "boys":
                            sportType = "Football";
                            pricePerNight = 15.00;
                            break;
                        case "mixed":
                            sportType = "Swimming";
                            pricePerNight = 20.00;
                            break;
                    }
                    break;
            }

            totalPrice = numStudents * pricePerNight * numNights;
            
            if (numStudents >= 50)
            {
                totalPrice *= 0.50;
            }
            else if (numStudents >= 20)
            {
                totalPrice *= 0.85;
            }
            else if (numStudents >= 10)
            {
                totalPrice *= 0.95;
            }

            Console.WriteLine($"{sportType} {totalPrice:f2} lv.");


        }
    }
}
