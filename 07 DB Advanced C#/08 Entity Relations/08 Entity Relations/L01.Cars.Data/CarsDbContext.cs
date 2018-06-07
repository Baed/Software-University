using System;
using L01.Cars.Data.Models;
using L01.Cars.Data.Models.Configuration;
using Microsoft.EntityFrameworkCore;

namespace L01.Cars.Data
{
    public class CarsDbContext : DbContext
    {
        public CarsDbContext()
        {

        }

        public CarsDbContext(DbContextOptions options)
        : base(options)
        {

        }

        public DbSet<Car> Cars { get; set; }

        public DbSet<Dealership> Dealerships { get; set; }

        public DbSet<CarDealership> CarDealerships { get; set; }

        public DbSet<Engine> Engines { get; set; }

        public DbSet<LicensePlate> LicensePlates { get; set; }

        public DbSet<Make> Makes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CarConfiguration());

            modelBuilder.ApplyConfiguration(new CarDealershipConfiguration());

            modelBuilder.ApplyConfiguration(new EngineConfiguration());

            modelBuilder.ApplyConfiguration(new MakeConfiguration());
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