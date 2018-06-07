using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using L01.Code_First_Demo.Data.Models;
using L01.Code_First_Demo.Data;
using Microsoft.EntityFrameworkCore;

namespace L01.Code_First_Demo.Data
{
    public class ForumDbContex : DbContext
    {
        public ForumDbContex()
        {

        }

        public ForumDbContex(DbContextOptions options)
        : base(options)
        {

        }

        public DbSet<User> Users { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Post> Posts { get; set; }

        public DbSet<Reply> Replies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder) // base prop in DbContext
        {
            base.OnConfiguring(builder);

            if (!builder.IsConfigured)
            {
                builder.UseSqlServer(Configuration.ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Category>()
                .HasMany(c => c.Posts)  //Icollection<Post> Category.Posts
                .WithOne(p => p.Category)
                .HasForeignKey(p => p.CategoryId);

            builder.Entity<Post>()
                .HasMany(p => p.Replies) //Icollection<Reply> Post.Replies
                .WithOne(r => r.Post)
                .HasForeignKey(r => r.PostId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<User>()
                .HasMany(u => u.Posts) //Icollection<Post> User.Posts
                .WithOne(p => p.Author)
                .HasForeignKey(r => r.AuthorID);

            builder.Entity<User>()
                .HasMany(u => u.Replies) //Icollection<Reply> User.Replies
                .WithOne(p => p.Author)
                .HasForeignKey(r => r.AuthorID);


            builder.Entity<PostTag>()
                .HasKey(pt => new {pt.PostId, pt.TagId}); // COMPOSITE KEY
        }


    }
}
