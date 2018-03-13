using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_BillsPaymentSystem.Data.Models
{
    public class BankAccount
    {
        public BankAccount()
        {
            
        }

        public BankAccount(decimal balance, string bankName, string swiftCode)
        {
            Balance = balance;
            BankName = bankName;
            SwiftCode = swiftCode;
        }

        public int BankAccountId { get; set; }

        public decimal Balance { get; set; }

        public string BankName { get; set; }

        public string SwiftCode { get; set; }

        public int PaymentMethodId { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
    }
}
