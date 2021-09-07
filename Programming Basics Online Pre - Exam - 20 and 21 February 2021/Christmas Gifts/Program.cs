using System;

namespace Christmas_Gifts
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int toyPrice = 5;
            int sweaterPrice = 15;
            int toyTotalPrice = 0;
            int sweaterTotalPrice = 0;
            int numChildren = 0;
            int numAdults = 0;

            while (input != "Christmas")
            {
                int age = int.Parse(input);

                if (age <= 16)
                {
                    numChildren++;
                    toyTotalPrice += toyPrice;
                }

                else
                {
                    numAdults++;
                    sweaterTotalPrice += sweaterPrice;
                }

                input = Console.ReadLine();

            }

            Console.WriteLine($"Number of adults: {numAdults}");
            Console.WriteLine($"Number of kids: {numChildren}");
            Console.WriteLine($"Money for toys: {toyTotalPrice}");
            Console.WriteLine($"Money for sweaters: {sweaterTotalPrice}");
        }
    }
}
