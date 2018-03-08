using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P03_FootballBetting.Data.Models;

namespace P03_FootballBetting.Data.Configurations
{
    public class TownConfiguration : IEntityTypeConfiguration<Town>
    {
        public void Configure(EntityTypeBuilder<Town> builder)
        {
            builder.HasKey(tw => tw.TownId);

            builder.Property(tw => tw.Name)
                .HasMaxLength(80)
                .IsRequired();

            builder.HasOne(tw => tw.Country)
                .WithMany(cr => cr.Towns)
                .HasForeignKey(tw => tw.CountryId);
        }
    }
}
