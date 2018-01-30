using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.User_Logs
{
    class Program
    {
        static void Main(string[] args)
        {
            var userData = new SortedDictionary<string, Dictionary<string, int>>();

            var line = Console.ReadLine();

            while (line != "end")
            {
                var tokens = line.Split(' ');

                var ip = tokens[0].Replace("IP=", "");

                var user = tokens[2].Replace("user=", "");

                if (!userData.ContainsKey(user))
                {
                    userData.Add(user, new Dictionary<string, int>());
                }
                if (!userData[user].ContainsKey(ip))
                {
                    userData[user].Add(ip, 0);
                }
                userData[user][ip] += 1;

                line = Console.ReadLine();
            }
            PrintResult(userData);
        }
        private static void PrintResult(SortedDictionary<string, Dictionary<string, int>> userData)
        {
            foreach (var user in userData)
            {
                Console.WriteLine($"{user.Key}:");
                Console.WriteLine($"{string.Join(", ", user.Value.Select(kvp => $"{kvp.Key} => {kvp.Value}"))}.");
            }
        }
    }
}
