using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.RainAir
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> customerData = new Dictionary<string, List<int>>();

            string command;
            while ((command = Console.ReadLine()) != "I believe I can fly!")
            {
                var cmdArgs = command.Split(new[] { " ", "=" }, StringSplitOptions.RemoveEmptyEntries);
                string name = cmdArgs[0];

                if (char.IsLetter(cmdArgs[0][0]) && char.IsNumber(cmdArgs[1][0]))
                {
                    List<int> flights = cmdArgs.Skip(1).Select(int.Parse).ToList();

                    if (!customerData.ContainsKey(name))
                    {
                        customerData.Add(name, new List<int>());
                    }

                    customerData[name] = flights.Concat(customerData[name]).ToList();
                    //customerData[name].AddRange(cmdArgs.Skip(1).Select(int.Parse));
                }
                else
                {
                    string nameTochange = cmdArgs[1];

                    List<int> changedFlight = customerData[nameTochange].ToList();
                    customerData[name] = changedFlight;

                    //customerData[name] = new List<int>(customerData[nameTochange]);
                }
            }
            Dictionary<string, List<int>> sortedCustomers = customerData
                                                              .OrderByDescending(x => x.Value.Count)
                                                              .ThenBy(x => x.Key)
                                                              .ToDictionary(x => x.Key, x => x.Value);
            foreach (var customer in sortedCustomers)
            {
                Console.WriteLine($"#{customer.Key} ::: {string.Join(", ", customer.Value.OrderBy(y => y))}");
            }
        }
    }
}
