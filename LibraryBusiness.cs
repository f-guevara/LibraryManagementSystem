using System.Collections.Generic;


namespace LibraryManagementSystem
{
    public static class Business
    {
        public static void AddBook(List<Book> books)
        {
            string title = ConsoleUI.GetInput("Enter the title of the book: ");
            string author = ConsoleUI.GetInput("Enter the author of the book: ");
            int year;

            while (!int.TryParse(ConsoleUI.GetInput("Enter the year of publication: "), out year))
            {
                Console.WriteLine("Invalid year. Please enter a valid year.");
            }

            books.Add(new Book(title, author, year));
            Console.WriteLine("Book added successfully!");
        }

        public static void DeleteBook(List<Book> books)
        {
            ConsoleUI.DisplayBooks(books);

            if (books.Count == 0)
            {
                Console.WriteLine("No books to delete.");
                return;
            }

            int index = ConsoleUI.GetBookIndex(books);
            books.RemoveAt(index);
            Console.WriteLine("Book deleted successfully!");
        }
    }
}

