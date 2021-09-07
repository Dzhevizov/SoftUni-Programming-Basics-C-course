using System;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int numStudents = int.Parse(Console.ReadLine());

            int topStudents = 0;
            int goodStudents = 0;
            int averageStudents = 0;
            int failedStudents = 0;
            double sumGrades = 0;

            double percentTopStudents = 0;
            double percentGoodStudents = 0;
            double percentAverageStudents = 0;
            double percentFailedStudents = 0;
            double averageGrades = 0;

            for (int nextStudent = 1; nextStudent <= numStudents; nextStudent++)
            {
                double personalGrade = double.Parse(Console.ReadLine());
                sumGrades += personalGrade;

                if (personalGrade >= 5.00)
                {
                    topStudents++;
                }
                else if (personalGrade >= 4.00)
                {
                    goodStudents++;
                }
                else if (personalGrade >= 3.00)
                {
                    averageStudents++;
                }
                else
                {
                    failedStudents++;
                }
            }

            percentTopStudents = (double)topStudents * 100 / numStudents;
            percentGoodStudents = (double)goodStudents * 100 / numStudents;
            percentAverageStudents = (double)averageStudents * 100 / numStudents;
            percentFailedStudents = (double)failedStudents * 100 / numStudents;
            averageGrades = sumGrades / numStudents;

            Console.WriteLine($"Top students: {percentTopStudents:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {percentGoodStudents:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {percentAverageStudents:f2}%");
            Console.WriteLine($"Fail: {percentFailedStudents:f2}%");
            Console.WriteLine($"Average: {averageGrades:f2}");
        }
    }
}
