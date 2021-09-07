using System;

namespace Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string searchedBook = Console.ReadLine();
            string checkedBook = Console.ReadLine();
            int checkedBooks = 0;

            while (checkedBook != "No More Books")
            {
                if (checkedBook == searchedBook)
                {
                    Console.WriteLine($"You checked {checkedBooks} books and found it.");
                    break;
                }
                checkedBooks++;
                checkedBook = Console.ReadLine();
            }

            if (checkedBook != searchedBook)
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {checkedBooks} books.");
            }
        }
    }
}
