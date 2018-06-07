using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_BillsPaymentSystem.Data.Models
{
    public class PaymentMethod
    {
        public PaymentMethod()
        {

        }

        public PaymentMethod(User user, CreditCard creditCard, PaymentMethodType type)
        {
            this.User = user;
            this.CreditCard = creditCard;
            this.PaymentMethodType = type;
        }

        public PaymentMethod(User user, BankAccount bancAccount, PaymentMethodType type)
        {
            this.User = user;
            this.BankAccount = bancAccount;
            this.PaymentMethodType = type;
        }

        public int Id { get; set; }

        public PaymentMethodType PaymentMethodType { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int? BankAccountId { get; set; }
        public BankAccount BankAccount { get; set; }

        public int? CreditCardId { get; set; }
        public CreditCard CreditCard { get; set; }
    }
}
