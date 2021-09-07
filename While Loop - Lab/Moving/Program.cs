using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int space = 0;
            space = width * length * height;
            int usedSpace = 0;

            string input = Console.ReadLine();

            while (input != "Done")
            {
                int numBoxes = int.Parse(input);
                usedSpace += numBoxes;

                if (usedSpace >= space)
                {
                    Console.WriteLine($"No more free space! You need {usedSpace - space} Cubic meters more.");
                    break;
                }
                input = Console.ReadLine();
            }

            if (usedSpace < space)
            {
                Console.WriteLine($"{space - usedSpace} Cubic meters left.");
            }
        }
    }
}
