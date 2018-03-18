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
    public class CategoryProductConfig : IEntityTypeConfiguration<CategoryProduct>
    {
        public void Configure(EntityTypeBuilder<CategoryProduct> entity)
        {
            entity.HasKey(e => new { e.ProductId, e.CategoryId });

            entity.HasOne(e => e.Product)
                .WithMany(p => p.CategoryProductses)
                .HasForeignKey(e => e.ProductId);

            entity.HasOne(e => e.Category)
                .WithMany(c => c.CategoryProductses)
                .HasForeignKey(e => e.CategoryId);
        }
    }
}
