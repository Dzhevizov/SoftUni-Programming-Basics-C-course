using System;

namespace Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            int soldTickets = 0;
            int studentTickets = 0;
            int standardTickets = 0;
            int kidTickets = 0;
            int totalTickets = 0;
            double percentSold = 0;
            double percentStudentTickets = 0;
            double percentStandardTickets = 0;
            double percentKidTickets = 0;

            while (movie != "Finish")
            {
                int vacancies = int.Parse(Console.ReadLine());
                string ticketType = Console.ReadLine();

                while (ticketType != "End")
                {
                    soldTickets++;
                    totalTickets++;
                    if (ticketType == "student")
                    {
                        studentTickets++;
                    }
                    else if (ticketType == "standard")
                    {
                        standardTickets++;
                    }
                    else if (ticketType == "kid")
                    {
                        kidTickets++;
                    }
                    if (soldTickets == vacancies)
                    {
                        break;
                    }
                    ticketType = Console.ReadLine();
                }
                percentSold = (double)soldTickets * 100 / vacancies;
                Console.WriteLine($"{movie} - {percentSold:f2}% full.");
                soldTickets = 0;
                movie = Console.ReadLine();
            }

            percentStudentTickets = (double)studentTickets * 100 / totalTickets;
            percentStandardTickets = (double)standardTickets * 100 / totalTickets;
            percentKidTickets = (double)kidTickets * 100 / totalTickets;

            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{percentStudentTickets:f2}% student tickets.");
            Console.WriteLine($"{percentStandardTickets:f2}% standard tickets.");
            Console.WriteLine($"{percentKidTickets:f2}% kids tickets.");
        }
    }
}
