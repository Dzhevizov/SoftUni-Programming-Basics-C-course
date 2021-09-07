using System;

namespace Stream_Of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string nextLetter = Console.ReadLine();
            string word = null;
            char a = '0';
            int c1 = 0;
            int o1 = 0;
            int n1 = 0;

            while (nextLetter != "End")
            {
                a = char.Parse(nextLetter);
                if (a == 'c')
                {
                    if (c1 == 0)
                    {
                        c1++;
                    }
                    else
                    {
                        word = word + a;
                    }
                }
                else if (a == 'o')
                {
                    if (o1 == 0)
                    {
                        o1++;
                    }
                    else
                    {
                        word = word + a;
                    }
                }
                else if (a == 'n')
                {
                    if (n1 == 0)
                    {
                        n1++;
                    }
                    else
                    {
                        word = word + a;
                    }
                }
                else if ((a >= 'a' && a <= 'z') || (a >= 'A' && a <= 'Z')) 
                {
                    word = word + a;        
                }
                if (c1 > 0 && o1 > 0 && n1 > 0)
                {
                    Console.Write($"{word} ");
                    c1 = 0;
                    o1 = 0;
                    n1 = 0;
                    word = null;
                }
                nextLetter = Console.ReadLine();
            }
        }
    }
}
