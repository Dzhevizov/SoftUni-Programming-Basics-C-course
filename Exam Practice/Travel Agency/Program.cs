using System;

namespace Travel_Agency
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            string package = Console.ReadLine();
            string vipDiscount = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            double pricePerDay = 0;
            double totalPrice = 0;

            switch (city)
            {
                case "Bansko":
                case "Borovets":
                    switch (package)
                    {
                        case "withEquipment":
                            pricePerDay = 100;
                            if (vipDiscount == "yes")
                            {
                                pricePerDay *= 0.90;
                            }
                            break;
                        case "noEquipment":
                            pricePerDay = 80;
                            if (vipDiscount == "yes")
                            {
                                pricePerDay *= 0.95;
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid input!");
                            return;
                    }
                    break;
                case "Varna":
                case "Burgas":
                    switch (package)
                    {
                        case "withBreakfast":
                            pricePerDay = 130;
                            if (vipDiscount == "yes")
                            {
                                pricePerDay *= 0.88;
                            }
                            break;
                        case "noBreakfast":
                            pricePerDay = 100;
                            if (vipDiscount == "yes")
                            {
                                pricePerDay *= 0.93;
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid input!");
                            return;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid input!");
                    return;
            }

            if (days > 7)
            {
                totalPrice = (days - 1) * pricePerDay;
            }
            else if (days >= 1)
            {
                totalPrice = days * pricePerDay;
            }
            else
            {
                Console.WriteLine("Days must be positive number!");
                return;
            }

            Console.WriteLine($"The price is {totalPrice:f2}lv! Have a nice time!");
        }
    }
}
