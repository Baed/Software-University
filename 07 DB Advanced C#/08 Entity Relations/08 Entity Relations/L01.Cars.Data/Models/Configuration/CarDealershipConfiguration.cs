using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace L01.Cars.Data.Models.Configuration
{
    public class CarDealershipConfiguration : IEntityTypeConfiguration<CarDealership>
    {
        public void Configure(EntityTypeBuilder<CarDealership> builder)
        {

            builder.HasKey(cd => new { cd.CarId, cd.DealershipId });

            builder.HasOne(cd => cd.Car)
                    .WithMany(c => c.CarsDealerships)
                    .HasForeignKey(cd => cd.CarId);

            builder.HasOne(cd => cd.Dealership)
                    .WithMany(d => d.CarsDealerships)
                    .HasForeignKey(cd => cd.DealershipId);

        }
    }
}
