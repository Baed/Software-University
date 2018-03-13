using System;
using Microsoft.EntityFrameworkCore;
using P01_BillsPaymentSystem.Data;
using P01_BillsPaymentSystem.Data.Models;

namespace P01_BillsPaymentSystem.App
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var context = new BillsPaymentSystemContext())
            {
                CreateDatabase(context);
            }
        }

        private static void CreateDatabase(BillsPaymentSystemContext context)
        {
            //context.Database.EnsureDeleted();

            //context.Database.EnsureCreated();

            //context.Database.Migrate();
                
            Seed(context);
        }

        private static void Seed(BillsPaymentSystemContext context)
        {
            var user = new User("John", "Smith", "smithJs@gmail.com", "kukuRuk8");

            var cards = new CreditCard[]
            {
                new CreditCard(100m,50m,new DateTime(1999,02,05)),
                new CreditCard(20000,3000,new DateTime(2012,05,06)),
            };

            var bankAccount = new BankAccount(1000m, "RoberyBank", "SWPP252P");

            var paymentMethods = new PaymentMethod[]
            {
                new PaymentMethod(user, cards[0], PaymentMethodType.CreditCard),
                new PaymentMethod(user, cards[1], PaymentMethodType.CreditCard),
                new PaymentMethod(user, bankAccount, PaymentMethodType.BankAccount),
            };

            context.Users.Add(user);
            context.CreditCards.AddRange(cards);
            context.BankAccounts.Add(bankAccount);
            context.PaymentMethods.AddRange(paymentMethods);

            context.SaveChanges();
        }
    }
}
// Install-Package Microsoft.EntityFrameworkCore.SqlServer
// Install-Package Microsoft.EntityFrameworkCore.Tools
// Drop-Database
// Update-Database
// Add-Migration Initial
// Remove-Migration
// Update-Database -Migration: "Initial"