using System;

namespace Fitness_Card
{
    class Program
    {
        static void Main(string[] args)
        {
            double amount = double.Parse(Console.ReadLine());
            char sex = char.Parse(Console.ReadLine());
            int age = int.Parse(Console.ReadLine());
            string sport = Console.ReadLine();

            double cardPrice = 0;
                            
            switch (sex)
            {
                case 'm':
                    switch (sport)
                    {
                        case "Gym":
                            cardPrice = 42;
                            break;
                        case "Boxing":
                            cardPrice = 41;
                            break;
                        case "Yoga":
                            cardPrice = 45;
                            break;
                        case "Zumba":
                            cardPrice = 34;
                            break;
                        case "Dances":
                            cardPrice = 51;
                            break;
                        case "Pilates":
                            cardPrice = 39;
                            break;
                    }
                    break;
                case 'f':
                    switch (sport)
                    {
                        case "Gym":
                            cardPrice = 35;
                            break;
                        case "Boxing":
                            cardPrice = 37;
                            break;
                        case "Yoga":
                            cardPrice = 42;
                            break;
                        case "Zumba":
                            cardPrice = 31;
                            break;
                        case "Dances":
                            cardPrice = 53;
                            break;
                        case "Pilates":
                            cardPrice = 37;
                            break;
                    }
                    break;
            }

            if (age <= 19)
            {
                cardPrice *= 0.80;
            }

            if (amount >= cardPrice)
            {
                Console.WriteLine($"You purchased a 1 month pass for {sport}.");
            }
            else
            {
                Console.WriteLine($"You don't have enough money! You need ${cardPrice - amount:f2} more.");
            }

        }
    }
}
