using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Defining_Classes
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<int, BankAccount> bankAccountsData = new Dictionary<int, BankAccount>();          

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                var cmdArgs = command
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                switch (cmdArgs[0])
                {
                    case "Create": Create(cmdArgs, bankAccountsData); break;                        
                    case "Deposit": Deposit(cmdArgs, bankAccountsData); break;                      
                    case "Withdraw": Withdraw(cmdArgs, bankAccountsData); break;                        
                    case "Print": Print(cmdArgs, bankAccountsData); break;                    
                }
            }

            List<BankAccount> acc = bankAccountsData.Values.ToList();

            Person person = new Person("Gosho", 20, acc);

            Console.WriteLine($"Person: {person.Name}, Age: {person.Age}, Ballance: {string.Join(", ", person.Accounts)}");
        }

        private static void Print(string[] cmdArgs, Dictionary<int, BankAccount> bankAccountsData)
        {
            if (!IsAccountExist(bankAccountsData, int.Parse(cmdArgs[1])))
            {
                Console.WriteLine("Account does not exist");
                return;
            }

            Console.WriteLine(bankAccountsData[int.Parse(cmdArgs[1])]);
        }

        private static void Withdraw(string[] cmdArgs, Dictionary<int, BankAccount> bankAccountsData)
        {
            if (!IsAccountExist(bankAccountsData, int.Parse(cmdArgs[1])))
            {
                Console.WriteLine($"Account does not exist");
                return;
            }

            var id = int.Parse(cmdArgs[1]);
            var amount = decimal.Parse(cmdArgs[2]);
            bankAccountsData[id].Withdraw(amount);
        }

        private static void Deposit(string[] cmdArgs, Dictionary<int, BankAccount> bankAccountsData)
        {
            if (!IsAccountExist(bankAccountsData, int.Parse(cmdArgs[1])))
            {
                Console.WriteLine($"Account does not exist");
                return;
            }

            var id = int.Parse(cmdArgs[1]);
            var amount = decimal.Parse(cmdArgs[2]);
            bankAccountsData[id].Deposit(amount);;
        }

        private static void Create(string[] cmdArgs, Dictionary<int, BankAccount> bankAccountsData)
        {
            if (!bankAccountsData.ContainsKey(int.Parse(cmdArgs[1])))
            {
                BankAccount account = new BankAccount(int.Parse(cmdArgs[1]));
                bankAccountsData.Add(int.Parse(cmdArgs[1]), account);
            }
            else
            {
                Console.WriteLine($"Account already exists");
            }
        }

        private static bool IsAccountExist(Dictionary<int, BankAccount> bankAccountsData, int id)
        {
            return bankAccountsData.ContainsKey(id);
        }
    }
}
