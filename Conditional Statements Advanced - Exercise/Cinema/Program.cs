using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            int seats = rows * columns;
            double totalIncome = 0;

            switch (type)
            {
                case "Premiere":
                    totalIncome = seats * 12;
                    break;
                case "Normal":
                    totalIncome = seats * 7.5;
                    break;
                case "Discount":
                    totalIncome = seats * 5;
                    break;
            }

            Console.WriteLine($"{totalIncome:f2} leva");
        }
    }
}
