using System;

namespace Agency_Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            string airline = Console.ReadLine();
            int numAdultTickets = int.Parse(Console.ReadLine());
            int numKidsTickets = int.Parse(Console.ReadLine());
            double priceAdultTicketNeto = double.Parse(Console.ReadLine());
            double servingPrice = double.Parse(Console.ReadLine());

            double priceKidsTicketNeto = priceAdultTicketNeto * 0.30;
            double totalPrice = numAdultTickets * priceAdultTicketNeto + numKidsTickets * priceKidsTicketNeto +
                (numAdultTickets + numKidsTickets) * servingPrice;
            double profit = totalPrice * 0.20;
            Console.WriteLine($"The profit of your agency from {airline} tickets is {profit:f2} lv.");
        }
    }
}
