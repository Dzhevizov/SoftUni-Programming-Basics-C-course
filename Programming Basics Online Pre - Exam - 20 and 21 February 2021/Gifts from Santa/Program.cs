using System;

namespace Gifts_from_Santa
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int S = int.Parse(Console.ReadLine());

            for (int currAddress = M; currAddress >= N; currAddress--)
            {
                if ((currAddress % 2 == 0) && (currAddress % 3 == 0))
                {
                    if (currAddress == S)
                    {
                        return;
                    }

                    Console.Write($"{currAddress} ");
                }
            }
        }
    }
}
