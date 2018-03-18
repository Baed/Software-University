using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forum.Data;
using Forum.Models;
using Forum.Servises.Contracts;
using Microsoft.EntityFrameworkCore;

namespace Forum.Servises
{
    public class DbInitializerService : IDbInitializerService
    {
        private readonly ForumDbContex context;

        public DbInitializerService(ForumDbContex context)
        {
            this.context = context;
        }

        public void InitializeDb()
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            //context.Database.GetMigrations();

            Console.WriteLine("Forum database created successfully.");

           // Seed(context);
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

            Console.WriteLine("Sample data inserted successfully.");
        }
    }
}
