using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Task4
{
    class Task4
    {
        static void Main(string[] args)
        {
            List<Book> books = LoadBooks();
            BookLibrary library = new BookLibrary(books);

            Console.WriteLine("Books starting with 'The':");
            foreach (var book in library.BooksStartingWithThe())
            {
                Console.WriteLine(book.Title);
            }

            Console.WriteLine("\nBooks by authors with 't' in their name:");
            foreach (var book in library.BooksByAuthorsWithTInName())
            {
                Console.WriteLine($"{book.Author} - {book.Title}");
            }

            Console.WriteLine($"\nNumber of books after 1992: {library.CountBooksAfter1992()}");

            Console.WriteLine($"\nNumber of books before 2004: {library.CountBooksBefore2004()}");

            string authorToSearch = "Terry Pratchett"; 
            Console.WriteLine($"\nISBNs for books by {authorToSearch}:");
            foreach (var isbn in library.IsbnForAuthor(authorToSearch))
            {
                Console.WriteLine(isbn);
            }

            Console.WriteLine("\nBooks in alphabetical order:");
            foreach (var book in library.ListBooksAlphabetically())
            {
                Console.WriteLine(book.Title);
            }

            Console.WriteLine("\nBooks in chronological order:");
            foreach (var book in library.ListBooksChronologically())
            {
                Console.WriteLine($"{book.PublicationYear} - {book.Title}");
            }

            Console.WriteLine("\nBooks grouped by author last name:");
            foreach (var group in library.ListBooksGroupedByAuthorLastName())
            {
                Console.WriteLine(group.Key);
                foreach (var book in group)
                {
                    Console.WriteLine($"- {book.Title}");
                }
            }

            Console.WriteLine("\nBooks grouped by author first name:");
            foreach (var group in library.ListBooksGroupedByAuthorFirstName())
            {
                Console.WriteLine(group.Key);
                foreach (var book in group)
                {
                    Console.WriteLine($"- {book.Title}");
                }
            }
        }

        static List<Book> LoadBooks()
    {
        string filePath = "books.json";
try
{
string jsonString = File.ReadAllText(filePath);
return JsonSerializer.Deserialize<List<Book>>(jsonString) ?? new List<Book>();
}
catch (FileNotFoundException)
{
    Console.WriteLine($"Error: The file {filePath} was not found.");
}
catch (JsonException jsonEx)
{
    Console.WriteLine($"JSON Format Error: {jsonEx.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}
return new List<Book>();

        }
    }
}
