using System;
using System.Collections.Generic;



namespace LibraryManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize the book list with some hardcoded data
            List<Book> books = new List<Book>
            {
                new Book("1984", "George Orwell", 1949),
                new Book("To Kill a Mockingbird", "Harper Lee", 1960),
                new Book("The Great Gatsby", "F. Scott Fitzgerald", 1925)
            };

            while (true)
            {
                int choice = ConsoleUI.ShowMainMenu();
                switch (choice)
                {
                    case 1:
                        Business.AddBook(books);
                        break;
                    case 2:
                        Business.DeleteBook(books);
                        break;
                    case 3:
                        ConsoleUI.DisplayBooks(books);
                        break;
                    case 4:
                        Console.WriteLine("Exiting program.");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
