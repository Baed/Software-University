using System;
using Microsoft.EntityFrameworkCore;
using P01_BillsPaymentSystem.Data;
using P01_BillsPaymentSystem.Data.Models;

namespace P01_BillsPaymentSystem.App
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var context = new BillsPaymentSystemContext())
            {
                CreateDatabase(context);
            }
        }

        private static void CreateDatabase(BillsPaymentSystemContext context)
        {
            context.Database.EnsureDeleted();

            //context.Database.EnsureCreated();

            context.Database.Migrate();

            Seed(context);
        }

        private static void Seed(BillsPaymentSystemContext context)
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