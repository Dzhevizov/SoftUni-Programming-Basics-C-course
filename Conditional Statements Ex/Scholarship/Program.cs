using System;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double avSuccess = double.Parse(Console.ReadLine());
            double minAvSalary = double.Parse(Console.ReadLine());

            double socScholarship = minAvSalary * 0.35;
            double excGradesScholarship = avSuccess * 25;

            if (avSuccess >= 5.50)
            {
                if (income < minAvSalary)
                {
                    if (socScholarship > excGradesScholarship)
                    {
                        Console.WriteLine($"You get a Social scholarship {Math.Floor(socScholarship)} BGN");
                    }
                    else
                    {
                        Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(excGradesScholarship)} BGN");
                    }
                }
                else
                {
                    Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(excGradesScholarship)} BGN");
                }

            }    
            else if (avSuccess > 4.50 && income < minAvSalary)
            {
                Console.WriteLine($"You get a Social scholarship {Math.Floor(socScholarship)} BGN");
            }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            
        }
    }
}
