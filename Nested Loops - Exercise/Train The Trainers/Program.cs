using System;

namespace Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int juriMembers = int.Parse(Console.ReadLine());
            string presentation = Console.ReadLine();

            int numPresentation = 0;
            double sumAverageMarks = 0;
            double averageAssessment = 0;

            while (presentation != "Finish")
            {
                double sumMarks = 0;
                double averageMark = 0;

                for (int i = 1; i <= juriMembers; i++)
                {
                    double marks = double.Parse(Console.ReadLine());
                    sumMarks += marks;
                }

                averageMark = sumMarks / juriMembers;
                Console.WriteLine($"{presentation} - {averageMark:f2}.");
                numPresentation++;
                sumAverageMarks += averageMark;
                presentation = Console.ReadLine();
            }

            averageAssessment = sumAverageMarks / numPresentation;
            Console.WriteLine($"Student's final assessment is {averageAssessment:f2}.");
        }
    }
}
