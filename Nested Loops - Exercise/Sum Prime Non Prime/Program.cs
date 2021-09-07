using System;

namespace Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool isPrime = false;
            int sumPrime = 0;
            int sumNonPrime = 0;

            while (input != "stop")
            {
                int number = int.Parse(input);
                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else if (number >= 0 && number <= 3)
                {
                    isPrime = true;
                }
                else if (number % 2 == 0)
                {
                    isPrime = false;
                }
                else
                {
                    int boundary = (int)Math.Floor(Math.Sqrt(number));
                    for (int i = 3; i <= boundary; i += 2)
                    {
                        if (number % i == 0)
                        {
                            isPrime = false;
                            break;
                        }
                        else
                        {
                            isPrime = true;
                        }
                    }
                }
                if ((isPrime == true) && number >= 0)
                {
                    sumPrime += number;
                }
                else if ((isPrime == false) && number >= 0)
                {
                    sumNonPrime += number;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrime}");
        }
    }
}
