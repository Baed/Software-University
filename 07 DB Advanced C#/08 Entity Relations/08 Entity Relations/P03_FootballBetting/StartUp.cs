using System;
using Microsoft.EntityFrameworkCore;
using P03_FootballBetting.Data;
using P03_FootballBetting.Data.Models;

namespace P03_FootballBetting
{
    class StartUp
    {
        static void Main(string[] args)
        {
            using (var context = new FootballBettingContext())
            {
                CreateDatabase(context);
            }
        }

        private static void CreateDatabase(FootballBettingContext context)
        {
            context.Database.EnsureDeleted();

            //context.Database.EnsureCreated();

            context.Database.Migrate();

            Seed(context);
        }

        private static void Seed(FootballBettingContext context)
        {
            Console.WriteLine();
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
