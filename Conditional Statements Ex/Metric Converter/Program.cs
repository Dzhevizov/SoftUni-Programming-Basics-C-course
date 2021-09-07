using System;

namespace Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string type1 = Console.ReadLine();
            string type2 = Console.ReadLine();

            if (type1 == "mm" && type2 == "cm")
            {
                Console.WriteLine($"{number / 10:f3}");
            }
            else if (type1 == "mm" && type2 == "m")
            {
                Console.WriteLine($"{number / 1000:f3}");
            }
            else if (type1 == "cm" && type2 == "mm")
            {
                Console.WriteLine($"{number * 10:f3}");
            }
            else if (type1 == "cm" && type2 == "m")
            {
                Console.WriteLine($"{number / 100:f3}");
            }
            else if (type1 == "m" && type2 == "mm")
            {
                Console.WriteLine($"{number * 1000:f3}");
            }
            else if (type1 == "m" && type2 == "cm")
            {
                Console.WriteLine($"{number * 100:f3}");
            }
            else
            {
                Console.WriteLine($"{number:f3}");
            }
        }
    }
}


