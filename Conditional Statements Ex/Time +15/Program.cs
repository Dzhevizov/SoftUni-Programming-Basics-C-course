using System;

namespace Time__15
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes = minutes + 15;

            if (minutes <= 59)
            {
                Console.WriteLine($"{hours%24}:{minutes%60}");
            }
            else
            {
                hours = hours + 1;
                
                if (minutes%60 < 10)
                {
                    Console.WriteLine($"{hours%24}:0{minutes%60}");
                }
                else
                {
                    Console.WriteLine($"{hours%24}:{minutes%60}");
                }
            }
        }
    }
}
