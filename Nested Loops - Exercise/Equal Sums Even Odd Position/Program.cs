using System;

namespace Equal_Sums_Even_Odd_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int lastNum = int.Parse(Console.ReadLine());
            int evenSum = 0;
            int oddSum = 0;

            for (int i = firstNum; i <= lastNum; i++)
            {
                string currNum = i.ToString();
                for (int j = 0; j < 6; j++)
                {
                    if ((j % 2) == 0)
                    {
                        evenSum += currNum[j];
                    }
                    else
                    {
                        oddSum += currNum[j];
                    }
                }
                if (evenSum == oddSum)
                {
                    Console.Write($"{currNum} ");
                }
                evenSum = 0;
                oddSum = 0;
            }
        }
    }
}
