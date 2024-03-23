using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace Task4
{
    public class BookLibrary
    {
        private List<Book> books;

        public BookLibrary(List<Book> books)
        {
            this.books = books ?? throw new ArgumentNullException(nameof(books));
        }

        public IEnumerable<Book> BooksStartingWithThe()
        {
            return books.Where(book => book.Title.StartsWith("The", StringComparison.OrdinalIgnoreCase));
        }

        public IEnumerable<Book> BooksByAuthorsWithTInName()
        {
            return books.Where(book => book.Author.ToLower().Contains('t'));
        }

        public int CountBooksAfter1992()
        {
            return books.Count(book => book.PublicationYear > 1992);
        }

        public int CountBooksBefore2004()
        {
            return books.Count(book => book.PublicationYear < 2004);
        }

        public IEnumerable<string> IsbnForAuthor(string author)
        {
            return books.Where(book => book.Author.Equals(author, StringComparison.OrdinalIgnoreCase))
                        .Select(book => book.Isbn);
        }

        public IEnumerable<Book> ListBooksAlphabetically(bool ascending = true)
        {
            return ascending ? books.OrderBy(book => book.Title) : books.OrderByDescending(book => book.Title);
        }

        public IEnumerable<Book> ListBooksChronologically(bool ascending = true)
        {
            return ascending ? books.OrderBy(book => book.PublicationYear) : books.OrderByDescending(book => book.PublicationYear);
        }

        public IEnumerable<IGrouping<string, Book>> ListBooksGroupedByAuthorLastName()
        {
            return books.GroupBy(book => book.Author.Split(' ').Last());
        }

        public IEnumerable<IGrouping<string, Book>> ListBooksGroupedByAuthorFirstName()
        {
            return books.GroupBy(book => book.Author.Split(' ').First());
        }
    }
}   