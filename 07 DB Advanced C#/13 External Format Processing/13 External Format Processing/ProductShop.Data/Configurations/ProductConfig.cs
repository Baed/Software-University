using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductShop.Models;

namespace ProductShop.Data.Configurations
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> entity)
        {
            entity.HasKey(e => e.Id);

            entity.Property(e => e.Name)
                .IsRequired(true)
                .IsUnicode(true);

            entity.Property(e => e.Price)
                .IsRequired(true);

            entity.Property(e => e.BuyerId)
                .IsRequired(false);

            entity.HasOne(e => e.Buyer)
                .WithMany(b => b.BougthProducts)
                .HasForeignKey(e => e.BuyerId);

            entity.HasOne(e => e.Seller)
                .WithMany(s => s.SoldProducts)
                .HasForeignKey(e => e.SellerId);
        }
    }
}
