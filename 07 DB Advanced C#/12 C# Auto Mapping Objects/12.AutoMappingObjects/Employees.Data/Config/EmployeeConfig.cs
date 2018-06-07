using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employees.Models;
using Microsoft.EntityFrameworkCore;

namespace Employees.Data.Config
{
    public class EmployeeConfig : IEntityTypeConfiguration<Employee>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Employee> entity)
        {
            entity.HasKey(e => e.Id);

            entity.Property(e => e.FirstName)
                .IsRequired(true)
                .HasMaxLength(50);

            entity.Property(e => e.LastName)
                .IsRequired(true)
                .HasMaxLength(50);

            entity.Property(e => e.Birthday)
                .IsRequired(false);

            entity.Property(e => e.Address)
                .IsRequired(false)
                .HasMaxLength(250);

            entity.Property(e => e.Salary)
                .IsRequired(true);
        }
    }
}
