using System;

namespace On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinutes = int.Parse(Console.ReadLine());

            examMinutes += examHour * 60;
            arrivalMinutes += arrivalHour * 60;
            int difference = 0;

            if (examMinutes >= arrivalMinutes && examMinutes <= arrivalMinutes + 30)
            {
                Console.WriteLine("On time");
                if (examMinutes > arrivalMinutes)
                {
                    difference = examMinutes - arrivalMinutes;
                    Console.WriteLine($"{difference} minutes before the start");
                }
            }
            else if (examMinutes > arrivalMinutes + 30)
            {
                Console.WriteLine("Early");
                difference = examMinutes - arrivalMinutes;
                if (difference < 60)
                {
                    Console.WriteLine($"{difference} minutes before the start");
                }
                else
                {
                    Console.WriteLine($"{difference / 60}:{difference % 60:d2} hours before the start");
                }
            }
            else
            {
                Console.WriteLine("Late");
                difference = arrivalMinutes - examMinutes;
                if (difference < 60)
                {
                    Console.WriteLine($"{difference} minutes after the start");
                }
                else
                {
                    Console.WriteLine($"{difference / 60}:{difference % 60:d2} hours after the start");
                }
            }
        }
    }
}
