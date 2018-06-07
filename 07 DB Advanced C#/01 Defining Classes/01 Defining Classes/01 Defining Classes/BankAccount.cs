using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Defining_Classes
{
    public class BankAccount
    {
        public BankAccount(int iD)
        {
            this.ID = iD;
        }

        public int ID { get; set; }

        public decimal Balance { get; set; }

        public void Deposit(decimal amount)
        {
            this.Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (this.Balance >= amount)
            {
                this.Balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient balance");
            }

        }

        public override string ToString()
        {
            return $"Account ID{this.ID}, balance {this.Balance:f2}.";
        }
    }
}
