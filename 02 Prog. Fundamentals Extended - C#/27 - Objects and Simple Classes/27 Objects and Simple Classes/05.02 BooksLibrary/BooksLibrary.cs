using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._02_BooksLibrary
{
    class BooksLibrary
    {
        static void Main(string[] args)
        {
            Library library = AddLibrary();

            var sortedLibrary = library
                .Books
                .Select(author => author.Author)
                .Distinct()
                .Select(obj => new
                {
                    Name = obj,
                    Sales = library.Books.Where(book => book.Author == obj).Sum(price => price.Price)
                })
                .OrderByDescending(authorInfo => authorInfo.Sales)
                .ThenBy(libraryName => libraryName.Name)
                .ToList();

            foreach (var author in sortedLibrary)
            {
                Console.WriteLine($"{author.Name} -> {author.Sales:f2}");
            }
        }

        private static Library AddLibrary()
        {
            Library library = new Library("", new List<Book>());
            List<Book> bookList = new List<Book>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                Book books = new Book(input[0], input[1], input[2], input[3], input[4], decimal.Parse(input[5]));
                bookList.Add(books);

                library = new Library(books.Author, bookList);
            }

            return library;
        }
    }

    class Book
    {
        public Book(string title, string author, string publisher, string date, string iSBN, decimal price)
        {
            this.Title = title;
            this.Author = author;
            this.Publisher = publisher;
            this.Date = date;
            this.ISBN = iSBN;
            this.Price = price;
        }

        public string Title { get; set; }

        public string Author { get; set; }

        public string Publisher { get; set; }

        public string Date { get; set; }

        public string ISBN { get; set; }

        public decimal Price { get; set; }
    }

    class Library
    {
        public Library(string name, List<Book> books)
        {
            this.Name = name;
            this.Books = books;
        }

        public string Name { get; set; }

        public List<Book> Books { get; set; }
    }
}
