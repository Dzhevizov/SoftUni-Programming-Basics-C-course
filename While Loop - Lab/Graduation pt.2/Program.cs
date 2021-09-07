using System;

namespace Graduation_pt._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int grade = 1;
            int fails = 0;
            double sumGrades = 0;
            double averageGrades = 0;

            while (grade <= 12)
            {
                double yearGrade = double.Parse(Console.ReadLine());
                if (yearGrade < 4.00)
                {
                    fails++;
                }
                else
                {
                    grade++;
                    fails = 0;
                    sumGrades += yearGrade;
                }
                if (fails == 2)
                {
                    Console.WriteLine($"{name} has been excluded at {grade} grade");
                    break;
                }
            }

            if (fails < 2)
            {
                averageGrades = sumGrades / 12;
                Console.WriteLine($"{name} graduated. Average grade: {averageGrades:f2}");
            }
        }
    }
}
