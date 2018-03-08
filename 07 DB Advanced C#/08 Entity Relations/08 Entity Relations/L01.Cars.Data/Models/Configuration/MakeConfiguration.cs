using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace L01.Cars.Data.Models.Configuration
{
    public class MakeConfiguration : IEntityTypeConfiguration<Make>
    {
        public void Configure(EntityTypeBuilder<Make> builder)
        {
                                                   // if was in Car.Entity   
            builder.HasMany(m => m.Cars)           // .HasOne(c => c.Make)
                    .WithOne(c => c.Make)          // .WithMany(m => m.Cars)
                    .HasForeignKey(m => m.MakeId);
        }
    }
}
