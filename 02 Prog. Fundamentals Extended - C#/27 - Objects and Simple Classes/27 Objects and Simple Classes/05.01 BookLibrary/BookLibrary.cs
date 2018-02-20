using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._01_BookLibrary
{
    class BookLibrary
    {
        static void Main(string[] args)
        {
            Library library = AddLibrary();

            foreach (var author in library.Books)
            {
                Console.WriteLine($"{author.Title} -> {author.Price:f2}");
            }


        }

        private static Library AddLibrary()
        {
            Library library = new Library();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                Book books = new Book(input[0], input[1], input[2], input[3], input[4], decimal.Parse(input[5]));

                library.Books.Add(books);
            }

            return null;
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
        public string Name { get; set; }

        public List<Book> Books { get; set; }
    }
}
