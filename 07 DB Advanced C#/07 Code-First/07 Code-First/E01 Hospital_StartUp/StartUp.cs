using System;
using E01HospitalDB.Data;
using E01HospitalDB.Data.Models;
using Microsoft.EntityFrameworkCore;
using HospitalDatabase.Initializer;

namespace E01_Hospital_StartUp
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            using (var dbContext = new HospitalDbContext())
            {
                DatabaseInitializer.InitialSeed(dbContext);
            }
        }
    }
}
// Install-Package Microsoft.EntityFrameworkCore.SqlServer
// Install-Package Microsoft.EntityFrameworkCore.Tools
// Update-Database
// Drop-Database
// Add-Migration Initial
// Remove-Migration Initial
// Update-Database -Migration: "Initial"
