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

            int index = ConsoleUI.GetBookIndexToDelete(books);
            books.RemoveAt(index);
            Console.WriteLine("Book deleted successfully!");
        }

        public static void UpdateBook(List<Book> books)
        {
            ConsoleUI.DisplayBooks(books);

            if (books.Count == 0)
            {
                Console.WriteLine("No books to update.");
                return;
            }

            int index = ConsoleUI.GetBookIndexToUpdate(books);

            Console.Write("Enter the new title (leave empty to keep the current one): ");
            string title = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(title))
            {
                books[index].Title = title;
            }

            Console.Write("Enter the new author (leave empty to keep the current one): ");
            string author = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(author))
            {
                books[index].Author = author;
            }

            Console.Write("Enter the new year (leave empty to keep the current one): ");
            string yearInput = Console.ReadLine();
            if (int.TryParse(yearInput, out int year))
            {
                books[index].Year = year;
            }

            Console.WriteLine("Book updated successfully!");
        }

        public static List<Book> SearchBooks(List<Book> books, string searchTerm)
        {
            return books.Where(b => b.Title.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                                    b.Author.Contains(searchTerm, StringComparison.OrdinalIgnoreCase))
                        .ToList();
        }
        public static List<Book> SortBooksByTitle(List<Book> books)
        {
            return books.OrderBy(b => b.Title).ToList();
        }

        public static List<Book> SortBooksByAuthor(List<Book> books)
        {
            return books.OrderBy(b => b.Author).ToList();
        }

        public static List<Book> SortBooksByYear(List<Book> books)
        {
            return books.OrderBy(b => b.Year).ToList();
        }



    }
}

