using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace L01.Cars.Data.Models.Configuration
{
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.HasOne(c => c.LicensePlate)
                    .WithOne(lp => lp.Car)
                    .HasForeignKey<LicensePlate>(lp => lp.CarId); // HasForeignKey<T> because is One to One
        }
    }
}
