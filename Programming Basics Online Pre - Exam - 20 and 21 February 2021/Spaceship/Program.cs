using System;

namespace Spaceship
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double averageHeight = double.Parse(Console.ReadLine());

            double spacecraftVolume = width * length * height;
            double roomVolume = (averageHeight + 0.40) * 2 * 2;

            double numAstronauts = Math.Floor(spacecraftVolume / roomVolume);

            if (numAstronauts < 3)
            {
                Console.WriteLine("The spacecraft is too small.");
            }
            else if (numAstronauts > 10)
            {
                Console.WriteLine("The spacecraft is too big.");
            }
            else
            {
                Console.WriteLine($"The spacecraft holds {numAstronauts} astronauts.");
            }
        }
    }
}
