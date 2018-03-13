using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P01_BillsPaymentSystem.Data.Models;

namespace P01_BillsPaymentSystem.Data.Configurations
{
    public class BankAccountConfiguration : IEntityTypeConfiguration<BankAccount>
    {
        public void Configure(EntityTypeBuilder<BankAccount> builder)
        {
            builder.HasKey(ba => ba.BankAccountId);

            builder.Property(ba => ba.BankName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(ba => ba.SwiftCode)
                .IsUnicode(false)
                .IsRequired()
                .HasMaxLength(20);

            builder.Ignore(ba => ba.PaymentMethodId);
        }
    }
}
