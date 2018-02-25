using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Defining_Classes
{
    public class Person
    {
        private Person()
        {
            this.Accounts = new List<BankAccount>();
        }

        public Person(string name, int age)
            : this()
        {
            this.Name = name;
            this.Age = age;
            this.Accounts = new List<BankAccount>();
        }

        public Person(string name, int age, List<BankAccount> accounts) 
            : this(name, age)
        {
            this.Accounts = accounts;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public List<BankAccount> Accounts { get; set; }

        public decimal GetBalance()
        {
            return this.Accounts.Sum(x => x.Balance);
        }
    }
}
