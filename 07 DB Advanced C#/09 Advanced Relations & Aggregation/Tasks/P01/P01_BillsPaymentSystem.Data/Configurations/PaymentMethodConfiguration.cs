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
    public class PaymentMethodConfiguration : IEntityTypeConfiguration<PaymentMethod>
    {
        public void Configure(EntityTypeBuilder<PaymentMethod> builder)
        {
            builder.HasKey(p => p.Id);

            //unique
            builder.HasIndex(e => new { e.UserId, e.BankAccountId, e.CreditCardId }).IsUnique();
            // .HasIndex is because some of entity are nullable

            builder.HasOne(p => p.User)
                .WithMany(u => u.PaymentMethods)
                .HasForeignKey(p => p.UserId);

            builder.HasOne(p => p.BankAccount)
                .WithOne(ba => ba.PaymentMethod)
                .HasForeignKey<BankAccount>(p => p.BankAccountId);

            builder.HasOne(p => p.CreditCard)
                .WithOne(cc => cc.PaymentMethod)
                .HasForeignKey<CreditCard>(p => p.CreditCardId);
        }
    }
}
