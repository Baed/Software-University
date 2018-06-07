using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Logs_Aggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintInput(GetInputData());
        }
        private static SortedDictionary<string, SortedDictionary<string, int>> GetInputData()
        {
            var data = new SortedDictionary<string, SortedDictionary<string, int>>();

            int cnt = int.Parse(Console.ReadLine());

            for (int i = 0; i < cnt; i++)
            {
                string[] tokens = Console.ReadLine().Split(' ');

                string user = tokens[1];
                string ipAdress = tokens[0];
                int duration = int.Parse(tokens[2]);

                if (!data.ContainsKey(user))
                {
                    data.Add(user, new SortedDictionary<string, int>());
                }
                if (!data[user].ContainsKey(ipAdress))
                {
                    data[user].Add(ipAdress, 0);
                }
                data[user][ipAdress] += duration;
            }
            return data;
        }
        private static void PrintInput(SortedDictionary<string, SortedDictionary<string, int>> data)
        {
            foreach (var user in data)
            {
                Console.WriteLine($"{user.Key}: {user.Value.Values.Sum()} [{string.Join(", ", user.Value.Keys)}]");
            }
        }
    }
}
