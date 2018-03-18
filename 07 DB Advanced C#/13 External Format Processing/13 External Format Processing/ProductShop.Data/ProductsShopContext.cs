using System;
using Microsoft.EntityFrameworkCore;
using ProductShop.Data.Configurations;
using ProductShop.Models;

namespace ProductShop.Data
{
    public class ProductsShopContext : DbContext
    {
        public ProductsShopContext()
        {

        }

        public ProductsShopContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<User> Users { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<CategoryProduct> CategoryProducts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfig());

            modelBuilder.ApplyConfiguration(new ProductConfig());

            modelBuilder.ApplyConfiguration(new CategoryConfig());

            modelBuilder.ApplyConfiguration(new CategoryProductConfig());
        }
    }
}
