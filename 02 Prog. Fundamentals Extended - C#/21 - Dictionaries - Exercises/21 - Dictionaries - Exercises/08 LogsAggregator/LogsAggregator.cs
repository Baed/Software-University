using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_LogsAggregator
{
    class LogsAggregator
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> data = new Dictionary<string, Dictionary<string, int>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] commandLine = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string user = commandLine[1];
                string ip = commandLine[0];
                int duration = int.Parse(commandLine[2]);

                if (!data.ContainsKey(user))
                {
                    data.Add(user, new Dictionary<string, int>());
                }

                if (!data[user].ContainsKey(ip))
                {
                    data[user].Add(ip, 0);
                }

                data[user][ip] += duration;
            }

            foreach (var kvp in data.OrderBy(u => u.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Values.Sum()} [{string.Join(", ", kvp.Value.Keys.OrderBy(i => i))}]");
            }
        }
    }
}
