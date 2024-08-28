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
                        Business.UpdateBook(books);
                        break;
                    case 4:
                        ConsoleUI.DisplayBooks(books);
                        break;
                    case 5:
                        int searchOption = ConsoleUI.ShowSearchMenu();
                        if (searchOption == 1 || searchOption == 2)
                        {
                            string searchTerm = ConsoleUI.GetSearchTerm();
                            List<Book> searchResults = Business.SearchBooks(books, searchTerm);
                            ConsoleUI.DisplaySearchResults(searchResults);
                        }
                        break;

                    case 6:
                        int sortOption = ConsoleUI.ShowSortMenu();
                        switch (sortOption)
                        {
                            case 1:
                                books = Business.SortBooksByTitle(books);
                                break;
                            case 2:
                                books = Business.SortBooksByAuthor(books);
                                break;
                            case 3:
                                books = Business.SortBooksByYear(books);
                                break;
                        }
                        ConsoleUI.DisplayBooks(books);
                        break;
                    case 7:
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
