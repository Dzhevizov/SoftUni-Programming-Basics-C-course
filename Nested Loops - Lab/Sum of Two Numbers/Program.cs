using System;

namespace Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int lastNum = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = firstNum; i <= lastNum; i++)
            {
                for (int j = firstNum; j <= lastNum; j++)
                {
                    counter++;
                    if ((i + j) == magicNum)
                    {
                        Console.WriteLine($"Combination N:{counter} ({i} + {j} = {magicNum})");
                        return;
                    }
                }
            }

            Console.WriteLine($"{counter} combinations - neither equals {magicNum}");
        }
    }
}
