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
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.UserId);

            builder.Property(u => u.Name)
                .HasMaxLength(100);

            builder.Property(u => u.Username)
                .HasMaxLength(30)
                .IsRequired();

            builder.Property(u => u.Password)
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(u => u.Email)
                .HasMaxLength(60)
                .IsRequired();
        }
    }
}
