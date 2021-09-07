using System;

namespace Cat_Life
{
    class Program
    {
        static void Main(string[] args)
        {
            string breed = Console.ReadLine();
            char sex = char.Parse(Console.ReadLine());

            int humanYears = 0;

            switch (breed)
            {
                case "British Shorthair":
                    switch (sex)
                    {
                        case 'm':
                            humanYears = 13;
                            break;
                        case 'f':
                            humanYears = 14;
                            break;
                    }
                    break;
                case "Siamese":
                    switch (sex)
                    {
                        case 'm':
                            humanYears = 15;
                            break;
                        case 'f':
                            humanYears = 16;
                            break;
                    }
                    break;
                case "Persian":
                    switch (sex)
                    {
                        case 'm':
                            humanYears = 14;
                            break;
                        case 'f':
                            humanYears = 15;
                            break;
                    }
                    break;
                case "Ragdoll":
                    switch (sex)
                    {
                        case 'm':
                            humanYears = 16;
                            break;
                        case 'f':
                            humanYears = 17;
                            break;
                    }
                    break;
                case "American Shorthair":
                    switch (sex)
                    {
                        case 'm':
                            humanYears = 12;
                            break;
                        case 'f':
                            humanYears = 13;
                            break;
                    }
                    break;
                case "Siberian":
                    switch (sex)
                    {
                        case 'm':
                            humanYears = 11;
                            break;
                        case 'f':
                            humanYears = 12;
                            break;
                    }
                    break;
                default:
                    Console.WriteLine($"{breed} is invalid cat!");
                    return;
            }

            double humanMonths = (double)humanYears * 12;
            double catMonts = Math.Floor(humanMonths / 6);

            Console.WriteLine($"{catMonts} cat months");
        }
    }
}
