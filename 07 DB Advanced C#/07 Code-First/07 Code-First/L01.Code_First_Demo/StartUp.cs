using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using L01.Code_First_Demo.Data;
using L01.Code_First_Demo.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace L01.Code_First_Demo
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            using (var context = new ForumDbContex())
            {
                ResetDatabase(context);

                var categories = context.Categories
                    .Include(c => c.Posts)
                    .ThenInclude(p => p.Author)
                    .Include(c => c.Posts)
                    .ThenInclude(p => p.Replies)
                    .ThenInclude(r => r.Author)
                    .ToList();

                foreach (var category in categories)
                {
                    Console.WriteLine($"{category.Name} ({category.Posts.Count})");

                    foreach (var catPost in category.Posts)
                    {
                        Console.WriteLine($"--Title: ({catPost.Title}) Content: {catPost.Content}");
                        Console.WriteLine($"-- by Author: {catPost.Author.Username}");

                        foreach (var reply in catPost.Replies)
                        {
                            Console.WriteLine($"---- {reply.Content} from {reply.Author.Username}");
                        }
                    }
                }
            }
        }

        private static void Seed(ForumDbContex context)
        {
            var usersList = new List<User>()
            {
                new User("Gosho", "1234564785"),
                new User("Pesho", "1234564785"),
                new User("Ivan", "1234564785"),
                new User("Stamat", "1234564785")
            };

            context.Users.AddRange(usersList);

            var categoriesList = new List<Category>()
            {
                new Category("C#"),
                new Category("Support"),
                new Category("Python"),
                new Category("EF COR")
            };

            context.Categories.AddRange(categoriesList);

            var postsList = new List<Post>()
            {
                new Post("C# Rulz", "Correct", categoriesList[0], usersList[0]),
                new Post("Python Rulz", "Bash Correct", categoriesList[2], usersList[1]),
                new Post("Support Rulz", "Everything is totally uncorrect", categoriesList[1], usersList[2]),
                new Post("EF COR Rulz", "Dremi na Cora is Correct", categoriesList[3], usersList[3]),
            };

            context.Posts.AddRange(postsList);

            var repliesList = new List<Reply>()
            {
                new Reply("Turn it On", postsList[2], usersList[0]),
                new Reply("Cora mi Qnko", postsList[0], usersList[2])
            };

            context.Replies.AddRange(repliesList);

            context.SaveChanges();
        }

        private static void ResetDatabase(ForumDbContex context)
        {
            context.Database.EnsureDeleted();

            context.Database.Migrate();

            Seed(context);
        }
    }
}

// Install-Package Microsoft.EntityFrameworkCore.SqlServer
// Install-Package Microsoft.EntityFrameworkCore.Tools
// Update-Database
// Drop-Database
// Add-Migration Initial
// Remove-Migration
// Update-Database -Migration: "Initial"