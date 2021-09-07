using System;

namespace House_Painting
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            
            double rearWallarea = x * x;
            double frontWallarea = rearWallarea - 1.2 * 2;
            double sideWallsarea = x * y - 1.5 * 1.5;
            double wallsArea = frontWallarea + rearWallarea + 2 * sideWallsarea;
            double greenPaint = wallsArea / 3.4;
            Console.WriteLine($"{greenPaint:f2}");

            double sideRoofsarea = x * y;
            double frontAndRearRoofsArea = x * h / 2;
            double roofsArea = 2 * sideRoofsarea + 2 * frontAndRearRoofsArea;
            double redPaint = roofsArea / 4.3;
            Console.WriteLine($"{redPaint:f2}");
        }
    }
}
