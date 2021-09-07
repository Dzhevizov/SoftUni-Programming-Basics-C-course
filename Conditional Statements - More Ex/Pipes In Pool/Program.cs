using System;

namespace Pipes_In_Pool
{
    class Program
    {
        static void Main(string[] args)
        {
            int V = int.Parse(Console.ReadLine());
            int P1 = int.Parse(Console.ReadLine());
            int P2 = int.Parse(Console.ReadLine());
            double H = double.Parse(Console.ReadLine());
            double V1 = P1 * H;
            double V2 = P2 * H;

            if (V1 + V2 <= V)
            {
                Console.WriteLine($"The pool is {(V1+V2)*100/V:f2}%full. Pipe 1: {V1*100/(V1+V2):f2}%. Pipe 2: {V2*100/(V1+V2):f2}%.");
            }

            else
            {
                Console.WriteLine($"For {H:f2} hours the pool overflows with {V1+V2-V:f2} litres.");
            }
            
        }
    }
}
