using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Launcher.cs.GameStore.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Launcher.cs.GameStore.Data
{
    public class GameStoreDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Game> Games { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder
                .UseSqlServer(@"Data Source=NVG\SQLEXPRESS;Database=GameStoreDb;Integrated Security=True;");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<UserGame>()
                .HasKey(ug => new { ug.GameId, ug.UserId });

            builder
                .Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();

            builder
                .Entity<User>()
                .HasMany(u => u.Games)
                .WithOne(ug => ug.User)
                .HasForeignKey(ug => ug.UserId);

            builder
                .Entity<Game>()
                .HasMany(g => g.Users)
                .WithOne(ug => ug.Game)
                .HasForeignKey(ug => ug.GameId);
        }
    }
}