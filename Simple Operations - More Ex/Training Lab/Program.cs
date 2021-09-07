using System;

namespace Training_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            h -= 1;
            int burosPerRow = (int)Math.Floor(h / 0.7);
            int rows = (int)Math.Floor(w / 1.2);
            int numOfBuros = burosPerRow * rows - 3;
            Console.WriteLine(numOfBuros);
        }
    }
}
