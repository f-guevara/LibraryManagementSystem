using System;

using System.Collections.Generic;


namespace LibraryManagementSystem
{
    public static class ConsoleUI
    {
        public static int ShowMainMenu()
        {
            Console.WriteLine("\nMain Menu:");
            Console.WriteLine("1. Add a Book");
            Console.WriteLine("2. Delete a Book");
            Console.WriteLine("3. Update a Book");
            Console.WriteLine("4. Display All Books");
            Console.WriteLine("5. Search for a Book");
            Console.WriteLine("6. Sort Books");
            Console.WriteLine("7. Quit");
            Console.Write("Choose an option: ");

            if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 1 && choice <= 7)
            {
                return choice;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 7.");
                return ShowMainMenu();
            }
        }


        public static void DisplayBooks(List<Book> books)
        {
            Console.WriteLine("\nList of Books:");
            if (books.Count == 0)
            {
                Console.WriteLine("No books available.");
            }
            else
            {
                for (int i = 0; i < books.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {books[i].Title} by {books[i].Author} ({books[i].Year})");
                }
            }
        }

        public static string GetInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        public static int GetBookIndexToDelete(List<Book> books)
        {
            Console.Write("Enter the number of the book to delete: ");
            if (int.TryParse(Console.ReadLine(), out int index) && index >= 1 && index <= books.Count)
            {
                return index - 1; // Adjust for 0-based index
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid book number.");
                return GetBookIndexToDelete(books);
            }
        }
        public static int GetBookIndexToUpdate(List<Book> books)
        {
            Console.Write("Enter the number of the book to update: ");
            if (int.TryParse(Console.ReadLine(), out int index) && index >= 1 && index <= books.Count)
            {
                return index - 1; // Adjust for 0-based index
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid book number.");
                return GetBookIndexToUpdate(books);
            }
        }

        public static int ShowSearchMenu()
        {
            Console.WriteLine("\nSearch Menu:");
            Console.WriteLine("1. Search by Title");
            Console.WriteLine("2. Search by Author");
            Console.WriteLine("3. Back to Main Menu");
            Console.Write("Choose an option: ");

            if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 1 && choice <= 3)
            {
                return choice;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 3.");
                return ShowSearchMenu();
            }
        }

        public static void DisplaySearchResults(List<Book> books)
        {
            if (books.Count == 0)
            {
                Console.WriteLine("No books found.");
                return;
            }

            foreach (var book in books)
            {
                Console.WriteLine($"{book.Title} by {book.Author}, Year: {book.Year}");
            }
        }

        public static string GetSearchTerm()
        {
            Console.Write("Enter search term: ");
            return Console.ReadLine();
        }

        public static int ShowSortMenu()
        {
            Console.WriteLine("\nSort Menu:");
            Console.WriteLine("1. Sort by Title");
            Console.WriteLine("2. Sort by Author");
            Console.WriteLine("3. Sort by Year");
            Console.WriteLine("4. Back to Main Menu");
            Console.Write("Choose an option: ");

            if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 1 && choice <= 4)
            {
                return choice;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
                return ShowSortMenu();
            }
        }


    }
}

