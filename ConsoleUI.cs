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
            Console.WriteLine("3. Display All Books");
            Console.WriteLine("4. Quit");
            Console.Write("Choose an option: ");

            if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 1 && choice <= 4)
            {
                return choice;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
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

        public static int GetBookIndex(List<Book> books)
        {
            Console.Write("Enter the number of the book to delete: ");
            if (int.TryParse(Console.ReadLine(), out int index) && index >= 1 && index <= books.Count)
            {
                return index - 1; // Adjust for 0-based index
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid book number.");
                return GetBookIndex(books);
            }
        }
    }
}

