using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Ordered_Banking_System
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, Dictionary<string, decimal>>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

                string bank = tokens[0];
                string account = tokens[1];
                decimal balance = decimal.Parse(tokens[2]);

                if (!data.ContainsKey(bank))
                {
                    data.Add(bank, new Dictionary<string, decimal>());
                }

                if (!data[bank].ContainsKey(account)) // zaradi += --> data[bank][account] += balance;
                {
                    data[bank].Add(account, 0);
                }

                data[bank][account] += balance;

                input = Console.ReadLine();
            }

            var orderedData = data.OrderByDescending
                (bankItem => 
                bankItem.Value.Values.Sum()
                ).ThenByDescending(bankItem => 
                bankItem.Value.Values.Max());

            foreach (var bankItem in orderedData)
            {
                string bank = bankItem.Key;
                Dictionary<string, decimal> accountData = bankItem.Value;

                var orderedAccountData = accountData.OrderByDescending(d => d.Value);

                foreach (var accountItem in orderedAccountData)
                {
                    string account = accountItem.Key;
                    decimal ballance = accountItem.Value;

                    Console.WriteLine("{0} -> {1} ({2})", account, ballance, bank);
                }
            }
        }
    }
}
