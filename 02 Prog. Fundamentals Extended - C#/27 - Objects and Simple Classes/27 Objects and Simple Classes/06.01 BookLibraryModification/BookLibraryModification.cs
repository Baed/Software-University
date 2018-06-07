using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._01_BookLibraryModification
{
    class BookLibraryModification
    {
        static void Main(string[] args)
        {
            Library library = AddLibrary();

            DateTime inputDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            Dictionary<string, DateTime> sortedData = new Dictionary<string, DateTime>();


            foreach (Book book in library.Books)
            {
                if (book.Date.CompareTo(inputDate) > 0)
                {
                    sortedData.Add(book.Title, book.Date);
                }
            }

            foreach (var author in sortedData.OrderBy(d => d.Value).ThenBy(a => a.Key))
            {
                Console.WriteLine($"{author.Key} -> {author.Value:dd.MM.yyyy}");
            }
        }

        private static Library AddLibrary()
        {
            Library library = new Library("", new List<Book>());
            List<Book> booksList = new List<Book>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                Book book = new Book(input[0], input[1], input[2], DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture), input[4], decimal.Parse(input[5]));
                booksList.Add(book);

                library = new Library(book.Author, booksList);
            }

            return library;
        }
    }

    class Book
    {
        public Book(string title, string author, string publisher, DateTime date, string iSBN, decimal price)
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

        public DateTime Date { get; set; }

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
