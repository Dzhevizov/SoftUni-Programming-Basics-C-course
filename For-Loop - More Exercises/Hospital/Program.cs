using System;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());

            int numDoctors = 7;
            int treatedPatients = 0;
            int untreatedPatients = 0;

            for (int countDays = 1; countDays <= period; countDays++)
            {
                if (countDays % 3 == 0 && untreatedPatients > treatedPatients)
                {
                    numDoctors++;
                }

                int incomingPatients = int.Parse(Console.ReadLine());
                if (incomingPatients <= numDoctors)
                {
                    treatedPatients += incomingPatients;
                }
                else
                {
                    treatedPatients += numDoctors;
                    untreatedPatients += incomingPatients - numDoctors;
                }
            }

            Console.WriteLine($"Treated patients: {treatedPatients}.");
            Console.WriteLine($"Untreated patients: {untreatedPatients}.");

        }
    }
}
