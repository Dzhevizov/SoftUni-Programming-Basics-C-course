using System;

namespace MyFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int duljina = int.Parse(Console.ReadLine());
            int shirochina = int.Parse(Console.ReadLine());
            int visochina = int.Parse(Console.ReadLine());
            double procent = double.Parse(Console.ReadLine());
            double litriVoda = ((duljina * shirochina * visochina) * 0.001) * (1 - (procent / 100));
            
            Console.WriteLine(litriVoda);
            
        }
    }
}
