using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> data = new Dictionary<string, Dictionary<string, List<string>>>();

            while (true)
            {
                string[] command = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "End")
                {
                    break;
                }

                // ID1 Gosho 10 20 30 40 50 60 70 80 
                // ID2 Stamat 11 22 33 44 55 66 77 88 
                // ID3 Ivan 100 200 300 400 500 600 700 800 
                // ID4 Pesho 11 21 31 41 51 61 71 81 
                // ID5 Pesho 15 51 341 56 51 65 75 85 
                // End

                string id = command[0];
                string name = command[1];
                List<string> numbers = command.Skip(2).ToList();

                if (!data.ContainsKey(command[0]))
                {
                    data.Add(command[0], new Dictionary<string, List<string>>());
                }

                data[command[0]][name] = numbers;
            }

            var keys = from entry in data
                where entry.Key == "ID1"
                select entry.Key;

            foreach (var key in keys)
            {
                Console.WriteLine("test: " + key);
            }

            string searchedID = data.FirstOrDefault(a => a.Key.Equals("ID1")).Key;
            Console.WriteLine("searched ID: "+ searchedID);

            string searchedName = data.FirstOrDefault(a => a.Value.Keys.Contains("Pesho")).Value.Keys.FirstOrDefault();
            Console.WriteLine("searched Name: "+ searchedName);

            List<string> searchedList = data.Values.FirstOrDefault(a => a.Keys.Contains("Stamat")).Select(d => d.Value).FirstOrDefault().ToList();
            Console.WriteLine("Searched List by name: " + string.Join(", ", searchedList));

            string number = data.Values.Skip(2).FirstOrDefault(a => a.Keys.Any()).Select(d => d.Value).FirstOrDefault().ToList()[1];
            Console.WriteLine("Searched second element in Third List: " + number);

            Dictionary<string, Dictionary<string, List<string>>> sortedCustomers = data
                .OrderByDescending(x => x.Value.Values.Count)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in sortedCustomers.OrderBy(x => x.Key))
            {
                Console.WriteLine(kvp.Key);

                foreach (var innerKvp in kvp.Value)
                {
                    Console.WriteLine(innerKvp.Key + ": " + string.Join(", ", innerKvp.Value));
                }
            }
        }
    }
}
