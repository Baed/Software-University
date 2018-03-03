namespace _04._RainAir
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> flightsByCustomerName = new Dictionary<string, List<int>>();
            
            string inputLine = string.Empty;

            while ((inputLine = Console.ReadLine()) != "I believe I can fly!")
            {
                string[] inputParameters = inputLine.Split(new []{' ', '='}, StringSplitOptions.RemoveEmptyEntries);

                if (char.IsLetter(inputParameters[0][0]) && char.IsNumber(inputParameters[1][0]))
                {
                    string customerName = inputParameters[0];
                    
                    if (!flightsByCustomerName.ContainsKey(customerName))
                    {
                        flightsByCustomerName[customerName] = new List<int>();
                    }

                    flightsByCustomerName[customerName].AddRange(inputParameters.Skip(1).Select(int.Parse));
                }
                else
                {
                    string originCustomerName = inputParameters[0];
                    string targetCustomerName = inputParameters[1];

                    flightsByCustomerName[originCustomerName] = new List<int>(flightsByCustomerName[targetCustomerName]);
                }
            }

            Dictionary<string, List<int>> sortedCustomers = 
                flightsByCustomerName
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
