using System;

namespace Back_To_The_Past
{
    class Program
    {
        static void Main(string[] args)
        {
            double inheritance = double.Parse(Console.ReadLine());
            int targetYear = int.Parse(Console.ReadLine());

            int age = 18;
            double costs = 0;

            for (int year = 1800; year <= targetYear; year++)
            {
                costs += 12000;
                
                if (year % 2 == 1)
                {
                    costs += 50 * age;
                }

                age++;
            }

            if (inheritance >= costs)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {inheritance - costs:f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {costs - inheritance:f2} dollars to survive.");
            }
        }
    }
}
