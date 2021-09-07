using System;

namespace Fuel_Tank___Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine();
            double fuelQuantity = double.Parse(Console.ReadLine());
            string clubCard = Console.ReadLine();
            
            double pricePerLiter = 0;
            
            switch (fuelType)
            {
                case "Gas":
                    if (clubCard == "Yes")
                    {
                        pricePerLiter = 0.93 - 0.08;
                    }
                    else
                    {
                        pricePerLiter = 0.93;
                    }
                    break;
                case "Gasoline":
                    if (clubCard == "Yes")
                    {
                        pricePerLiter = 2.22 - 0.18;
                    }
                    else
                    {
                        pricePerLiter = 2.22;
                    }
                    break;
                case "Diesel":
                    if (clubCard == "Yes")
                    {
                        pricePerLiter = 2.33 - 0.12;
                    }
                    else
                    {
                        pricePerLiter = 2.33;
                    }
                    break;
            }

            double totalPrice = 0;
            totalPrice = fuelQuantity * pricePerLiter;

            double discount = 0;

            if (fuelQuantity > 25)
            {
                discount = 0.10;
            }
            else if (fuelQuantity >= 20)
            {
                discount = 0.08;
            }

            totalPrice -= totalPrice * discount;

            Console.WriteLine($"{totalPrice:f2} lv.");
                                  
                        
        }
    }
}
