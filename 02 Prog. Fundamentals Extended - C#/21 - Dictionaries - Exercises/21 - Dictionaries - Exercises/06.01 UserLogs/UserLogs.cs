using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._01_UserLogs
{
    class UserLogs
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, int>> data = new SortedDictionary<string, Dictionary<string, int>>();

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                var tokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string user = tokens[2].Substring(5);
                string ip = tokens[0].Substring(3);
                string message = tokens[1].Substring(9, tokens[1].Length - 10);


                if (!data.ContainsKey(user))
                {
                    data.Add(user, new Dictionary<string, int>());
                }
                if (!data[user].ContainsKey(ip))
                {
                    data[user].Add(ip, 0);
                }

                data[user][ip] += 1;

            }

            foreach (var user in data.Keys.OrderBy(a => a))
            {
                Console.WriteLine($"{user}:");

                int cnt = 1;
                foreach (var ip in data[user])
                {
                    if (data[user].Count() == cnt)
                    {
                        Console.WriteLine($"{ip.Key} => {ip.Value}.");
                        break;
                    }
                    Console.Write($"{ip.Key} => {ip.Value}, ");
                    cnt++;
                }
            }

        }
    }
}
