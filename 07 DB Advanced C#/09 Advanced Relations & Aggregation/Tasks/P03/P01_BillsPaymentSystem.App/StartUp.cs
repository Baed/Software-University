using System;
using System.Globalization;
using System.Linq;
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
                //CreateDatabase(context);

                ExecuteProgram(context);
            }
        }

        private static void ExecuteProgram(BillsPaymentSystemContext context)
        {
            int userId = int.Parse(Console.ReadLine());

            var user = context.Users
                .Where(u => u.UserId == userId)
                .Select(u => new
                {
                    Name = $"{u.FirstName} {u.LastName}",
                    CreditCards = u.PaymentMethods
                        .Where(pm => pm.Type == PaymentMethodType.CreditCard)
                        .Select(pm => pm.CreditCard)
                        .ToList(),
                    BankAccounts = u.PaymentMethods
                        .Where(pm => pm.Type == PaymentMethodType.BankAccount)
                        .Select(pm => pm.BankAccount)
                        .ToList()
                })
                .FirstOrDefault();

            Console.WriteLine($"User: {user.Name}");

            var bankAccounts = user.BankAccounts;

            if (bankAccounts.Any())
            {
                Console.WriteLine("Bank Accounts:");

                foreach (var bankAccount in bankAccounts)
                {
                    Console.WriteLine($"-- ID: {bankAccount.BankAccountId}");
                    Console.WriteLine($"--- Balance: {bankAccount.Balance}");
                    Console.WriteLine($"--- Bank: {bankAccount.BankName}");
                    Console.WriteLine($"--- SWIFT: {bankAccount.SwiftCode}");
                }
            }

            var creditcards = user.CreditCards;

            if (creditcards.Any())
            {
                Console.WriteLine("Credit Cards:");

                foreach (var creditcard in creditcards)
                {
                    Console.WriteLine($"-- ID: {creditcard.CreditCardId}");
                    Console.WriteLine($"--- Limit: {creditcard.Limit}");
                    Console.WriteLine($"--- Money Owed: {creditcard.MoneyOwed}");
                    Console.WriteLine($"--- Limit LEft: {creditcard.LimitLeft}");
                    Console.WriteLine($"-- Expiration Date {creditcard.ExpirationDate.ToString("yyyy/MM", CultureInfo.InvariantCulture)}");
                }
            }



        }

        private static void CreateDatabase(BillsPaymentSystemContext context)
        {
            context.Database.EnsureDeleted();

            //context.Database.EnsureCreated();

            context.Database.Migrate();

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

