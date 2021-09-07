using System;

namespace Game_Of_Intervals
{
    class Program
    {
        static void Main(string[] args)
        {
            int moves = int.Parse(Console.ReadLine());

            int numsInt1 = 0;
            int numsInt2 = 0;
            int numsInt3 = 0;
            int numsInt4 = 0;
            int numsInt5 = 0;
            int numsInt6 = 0;

            double points = 0;
            double percentNumsInt1 = 0;
            double percentNumsInt2 = 0;
            double percentNumsInt3 = 0;
            double percentNumsInt4 = 0;
            double percentNumsInt5 = 0;
            double percentNumsInt6 = 0;

            for (int nextMove = 1; nextMove <= moves; nextMove++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number >= 0 && number <= 9)
                {
                    points += number * 0.2;
                    numsInt1++;
                }
                else if (number >= 10 && number <= 19)
                {
                    points += number * 0.3;
                    numsInt2++;
                }
                else if (number >= 20 && number <= 29)
                {
                    points += number * 0.4;
                    numsInt3++;
                }
                else if (number >= 30 && number <= 39)
                {
                    points += 50;
                    numsInt4++;
                }
                else if (number >= 40 && number <= 50)
                {
                    points += 100;
                    numsInt5++;
                }
                else
                {
                    points /= 2;
                    numsInt6++;
                }
            }

            percentNumsInt1 = (double)numsInt1 * 100 / moves;
            percentNumsInt2 = (double)numsInt2 * 100 / moves;
            percentNumsInt3 = (double)numsInt3 * 100 / moves;
            percentNumsInt4 = (double)numsInt4 * 100 / moves;
            percentNumsInt5 = (double)numsInt5 * 100 / moves;
            percentNumsInt6 = (double)numsInt6 * 100 / moves;

            Console.WriteLine($"{points:f2}");
            Console.WriteLine($"From 0 to 9: {percentNumsInt1:f2}%");
            Console.WriteLine($"From 10 to 19: {percentNumsInt2:f2}%");
            Console.WriteLine($"From 20 to 29: {percentNumsInt3:f2}%");
            Console.WriteLine($"From 30 to 39: {percentNumsInt4:f2}%");
            Console.WriteLine($"From 40 to 50: {percentNumsInt5:f2}%");
            Console.WriteLine($"Invalid numbers: {percentNumsInt6:f2}%");

        }
    }
}
