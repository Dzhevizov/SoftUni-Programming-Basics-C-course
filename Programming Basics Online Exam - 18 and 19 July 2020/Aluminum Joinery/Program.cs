using System;

namespace Aluminum_Joinery
{
    class Program
    {
        static void Main(string[] args)
        {
            int numJoinery = int.Parse(Console.ReadLine());
            string joineryType = Console.ReadLine();
            string deliveryType = Console.ReadLine();

            double singlePrice = 0;
            double totalPrice = 0;

            if (numJoinery < 10)
            {
                Console.WriteLine("Invalid order");
                return;
            }

            switch (joineryType)
            {
                case "90X130":
                    if (numJoinery <= 30)
                    {
                        singlePrice = 110;
                    }
                    else if (numJoinery <= 60)
                    {
                        singlePrice = 110 * 0.95;
                    }
                    else
                    {
                        singlePrice = 110 * 0.92;
                    }
                    break;
                case "100X150":
                    if (numJoinery <= 40)
                    {
                        singlePrice = 140;
                    }
                    else if (numJoinery <= 80)
                    {
                        singlePrice = 140 * 0.94;
                    }
                    else
                    {
                        singlePrice = 140 * 0.90;
                    }
                    break;
                case "130X180":
                    if (numJoinery <= 20)
                    {
                        singlePrice = 190;
                    }
                    else if (numJoinery <= 50)
                    {
                        singlePrice = 190 * 0.93;
                    }
                    else
                    {
                        singlePrice = 190 * 0.88;
                    }
                    break;
                case "200X300":
                    if (numJoinery <= 25)
                    {
                        singlePrice = 250;
                    }
                    else if (numJoinery <= 50)
                    {
                        singlePrice = 250 * 0.91;
                    }
                    else
                    {
                        singlePrice = 250 * 0.86;
                    }
                    break;
            }

            totalPrice = numJoinery * singlePrice;

            if (deliveryType == "With delivery")
            {
                totalPrice += 60;
            }

            if (numJoinery > 99)
            {
                totalPrice *= 0.96;
            }

            Console.WriteLine($"{totalPrice:f2} BGN");

        }
    }
}
