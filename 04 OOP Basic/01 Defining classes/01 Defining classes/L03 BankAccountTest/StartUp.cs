using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        var accounts = new Dictionary<int, BankAccount>();

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            var tokens = input.Split(' ');
            var command = tokens[0];
            switch (command)
            {
                case "Create": GetCreate(tokens, accounts); break;
                case "Deposit": GetDeposit(tokens, accounts); break;
                case "Withdraw": GetWithdraw(tokens, accounts); break;
                case "Print": GetPrint(tokens, accounts); break;
            }
        }
    }

    private static void GetPrint(string[] tokens, Dictionary<int, BankAccount> accounts)
    {
        var id = int.Parse(tokens[1]);

        if (accounts.ContainsKey(id))
        {
            Console.WriteLine(accounts[id].ToString());
        }
        else
        {
            Console.WriteLine("Account does not exist");
        }
    }

    private static void GetWithdraw(string[] tokens, Dictionary<int, BankAccount> accounts)
    {
        var id = int.Parse(tokens[1]);
        var amout = double.Parse(tokens[2]);

        if (accounts.ContainsKey(id))
        {
            if (accounts[id].Balance < amout)
            {
                Console.WriteLine("Insufficient balance");
            }
            else
            {
                accounts[id].Withdraw(amout);
            }
        }
        else
        {
            Console.WriteLine("Account does not exist");
        }
    }

    private static void GetDeposit(string[] tokens, Dictionary<int, BankAccount> accounts)
    {
        var id = int.Parse(tokens[1]);
        var amout = double.Parse(tokens[2]);

        if (accounts.ContainsKey(id))
        {
            accounts[id].Deposit(amout);
        }
        else
        {
            Console.WriteLine("Account does not exist");
        }
    }

    private static void GetCreate(string[] tokens, Dictionary<int, BankAccount> accounts)
    {
        var id = int.Parse(tokens[1]);

        if (!accounts.ContainsKey(id))
        {
            var acc = new BankAccount();
            acc.ID = id;
            accounts.Add(id, acc);
        }
        else
        {
            Console.WriteLine("Account already exists");
        }
    }
}
