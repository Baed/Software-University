using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarDealer.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarDealer.Data.Config
{
    public class PartCarConfig : IEntityTypeConfiguration<PartCar>
    {
        public void Configure(EntityTypeBuilder<PartCar> entity)
        {
            entity.HasKey(pc => new {pc.PartId, pc.CarId});

            entity.HasOne(pc => pc.Car)
                .WithMany(c => c.Parts)
                .HasForeignKey(pc => pc.CarId);


            entity.HasOne(pc => pc.Part)
                .WithMany(c => c.Cars)
                .HasForeignKey(pc => pc.PartId);
        }
    }
}
