﻿using System;

namespace Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            if (figure == "square")
            {
                double a = double.Parse(Console.ReadLine());
                double area = a * a;
                Console.WriteLine($"{area:f3}");
            }
            else if (figure == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double area = a * b;
                Console.WriteLine($"{area:f3}");
            }
            else if (figure == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                double area = Math.PI * r * r;
                Console.WriteLine($"{area:f3}");
            }
            else if (figure == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double ha = double.Parse(Console.ReadLine());
                double area = (a * ha) / 2;
                Console.WriteLine($"{area:f3}");
            }

        }
    }
}
