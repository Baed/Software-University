using System;
using System.Linq;
using System.Text;
using BookShop.Models;
using Microsoft.EntityFrameworkCore;
using BookShop.Data;
using BookShop.Initializer;

namespace BookShop
{
    public class StartUp
    {
        static void Main()
        {
            using (var context = new BookShopContext())
            {
                //DbInitializer.ResetDatabase(db);

                string command = Console.ReadLine();

                // //1
                // GetBooksByAgeRestriction(context, command);

                // //2
                // GetGoldenBooks(context);

                // //3
                // GetBooksByPrice(context);

                // //4
                // GetBooksNotRealeasedIn(context, command);

                // //5
                // GetBooksByCategory(context, command);

                // //6
                // GetBooksReleasedBefore(context, command);

                // //7
                // GetAuthorNamesEndingIn(context, command);

                // //8
                // GetBookTitlesContaining(context, command);

                // //9
                // GetBooksByAuthor(context, command);

                // //10
                // CountBooks(context, command);

                // //11
                // CountCopiesByAuthor(context);

                // //12
                // GetTotalProfitByCategory(context);

                // //13
                // GetMostRecentBooks(context);

                // //14
                // IncreasePrices(context);

                // //15
                // RemoveBooks(context);
            }
        }
        // 15.	Remove Books
        private static void RemoveBooks(BookShopContext context)
        {
            var currentBooks = context
                .Books
                .Where(b => b.Copies < 4200)
                .ToList();

            context.Books.RemoveRange(currentBooks);

            context.SaveChanges();

            string result = currentBooks.Count.ToString();

            Console.WriteLine($"{result} books were deleted");
        }

        // 14.	Increase Prices
        private static void IncreasePrices(BookShopContext context)
        {
            var currentBooks = context
                .Books
                .Where(b => b.ReleaseDate.Value.Year < 2010)
                .ToList();

            currentBooks.ForEach(b => b.Price += 5);

            context.SaveChanges();
        }

        // 13.	Most Recent Books
        private static void GetMostRecentBooks(BookShopContext context)
        {
            var sb = new StringBuilder();

            var categories = context
                .Categories
                .OrderBy(c => c.CategoryBooks.Count)
                .ThenBy(c => c.Name)
                .Select(c => new
                {
                    CategoryName = c.Name,
                    Book = c.CategoryBooks
                        .OrderByDescending(b => b.Book.ReleaseDate)
                        .Take(3)
                        .Select(b => new
                        {
                            BookTitle = b.Book.Title,
                            ReleaseYear = b.Book.ReleaseDate.Value.Year
                        })
                        .ToList()
                })
                .ToList();

            foreach (var category in categories)
            {
                sb.AppendLine($"--{category.CategoryName}");
                category.Book.ForEach(b => sb.AppendLine($"{b.BookTitle} ({b.ReleaseYear})"));
            }

            string result = sb.ToString().Trim();

            Console.WriteLine(result);
        }

        // 12.	Profit by Category
        private static void GetTotalProfitByCategory(BookShopContext context)
        {
            var sb = new StringBuilder();

            var categoryProfits = context
                .Categories
                .Select(c => new
                {
                    Name = c.Name,
                    Profit = c.CategoryBooks.Sum(b => b.Book.Copies * b.Book.Price)
                })
                .OrderByDescending(c => c.Profit)
                .ThenBy(c => c.Name)
                .ToList();

            categoryProfits.ForEach(c => sb.AppendLine($"{c.Name} ${c.Profit}"));

            string result = sb.ToString().Trim();

            Console.WriteLine(result);
        }

        // 11.	Total Book Copies
        private static void CountCopiesByAuthor(BookShopContext context)
        {
            var authorBooks = context
                .Authors
                .OrderByDescending(a => a.Books.Select(b => b.Copies).Sum())
                .Select(a => $"{a.FirstName} {a.LastName} - {a.Books.Sum(b => b.Copies)}")
                .ToList();

            string result = string.Join(Environment.NewLine, authorBooks);

            Console.WriteLine(result);
        }

        // 10.	Count Books
        private static void CountBooks(BookShopContext context, string command)
        {
            int lengthCheck = int.Parse(command);

            var bookCount = context.Books
                .Where(b => b.Title.Length > lengthCheck)
                .Count();

            Console.WriteLine(bookCount);

        }

        // 9. Book Search by Author
        private static void GetBooksByAuthor(BookShopContext context, string input)
        {
            var titles = context.Books
                .OrderBy(b => b.BookId)
                .Where(b => b.Author.LastName.ToLower().StartsWith(input.ToLower()))
                .Select(b => $"{b.Title} ({b.Author.FirstName} {b.Author.LastName})")
                .ToList();

            string result = string.Join(Environment.NewLine, titles);

            Console.WriteLine(result);
        }

        // 8. Book Search
        private static void GetBookTitlesContaining(BookShopContext context, string command)
        {
            var titles = context.Books
                .Where(b => b.Title.ToLower().Contains(command.ToLower()))
                .Select(b => b.Title)
                .OrderBy(b => b)
                .ToList();

            string result = string.Join(Environment.NewLine, titles);

            Console.WriteLine(result);
        }

        // 7. Author Search
        private static void GetAuthorNamesEndingIn(BookShopContext context, string command)
        {
            var authors = context.Authors
                .Where(a => a.FirstName.EndsWith(command))
                .Select(a => new
                {
                    FullName = $"{a.FirstName} {a.LastName}"
                })
                .OrderBy(a => a.FullName)
                .ToList();

            string result = string.Join(Environment.NewLine, authors);

            Console.WriteLine(result);
        }

        // 6. Released Before Date
        private static void GetBooksReleasedBefore(BookShopContext context, string command)
        {
            StringBuilder sb = new StringBuilder();

            DateTime checkDate = DateTime.ParseExact(command, "dd-MM-yyyy", null);

            var books = context.Books
                .Where(b => b.ReleaseDate < checkDate)
                .OrderByDescending(b => b.ReleaseDate)
                .Select(b => $"{b.Title} - {b.EditionType.ToString()} -${b.Price:f2}")
                .ToList();

            books.ForEach(b => sb.AppendLine(b));

            string result = sb.ToString().Trim();

            Console.WriteLine(result);
        }

        // 5. Book Titles by Category
        private static void GetBooksByCategory(BookShopContext context, string command)
        {
            var sb = new StringBuilder();

            var inputCategoryNames = command.ToLower().Split(new[] { "\t", " ", Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            var bookTitles = context.Books
                .Where(b => b.BookCategories
                      .Any(c => inputCategoryNames.Contains(c.Category.Name.ToLower())))
                .Select(b => b.Title)
                .OrderBy(b => b)
                .ToList();

            bookTitles.ForEach(b => sb.AppendLine(b));

            string result = sb.ToString().Trim();

            Console.WriteLine(result);
        }

        // 4. Not Released In
        private static void GetBooksNotRealeasedIn(BookShopContext context, string command)
        {
            int year = int.Parse(command);

            var sb = new StringBuilder();

            var bookTitles = context.Books
                .Where(b => b.ReleaseDate.HasValue && b.ReleaseDate.GetValueOrDefault().Year != year)
                .OrderBy(b => b.BookId)
                .Select(b => b.Title)
                .ToList();

            bookTitles.ForEach(b => sb.AppendLine(b));

            string result = sb.ToString().Trim();

            Console.WriteLine(result);
        }

        // 3. Books by Price
        private static void GetBooksByPrice(BookShopContext context)
        {
            var sb = new StringBuilder();

            var booksWithPrice = context.Books
                .Where(b => b.Price > 40)
                .Select(b => new
                {
                    b.Title,
                    b.Price
                })
                .OrderByDescending(b => b.Price)
                .ToList();

            booksWithPrice.ForEach(bp => sb.AppendLine($"{bp.Title} - ${bp.Price:f2}"));

            Console.WriteLine(sb.ToString().Trim());
        }

        // 2. Golden Books
        private static void GetGoldenBooks(BookShopContext context)
        {
            string[] titles = context.Books
                .Where(b => b.EditionType == EditionType.Gold && b.Copies < 5000)
                .OrderBy(b => b.BookId)
                .Select(b => b.Title)
                .ToArray();

            string result = string.Join(Environment.NewLine, titles);

            Console.WriteLine(result);
        }

        // 1. Age Restriction
        private static void GetBooksByAgeRestriction(BookShopContext context, string command)
        {
            int enumValue = int.MinValue;

            switch (command.ToLower())
            {
                case "minor": enumValue = 0; break;
                case "teen": enumValue = 1; break;
                case "adult": enumValue = 2; break;
            }

            string[] titles = context.Books
                .Where(b => b.AgeRestriction == (AgeRestriction)enumValue)
                .Select(b => b.Title)
                .OrderBy(t => t)
                .ToArray();

            string result = string.Join(Environment.NewLine, titles);

            Console.WriteLine(result);
        }
    }
}
// Install-Package Microsoft.EntityFrameworkCore.SqlServer
// Install-Package Microsoft.EntityFrameworkCore.Tools
// Drop-Database
// Update-Database
// Add-Migration Initial
// Remove-Migration
// Update-Database -Migration: "Initial"
// Install-Package Z.EntityFramework.Plus.EFCore
