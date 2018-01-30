using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _07.Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new[] { "\\", "/", "(", ")", " " }, StringSplitOptions.RemoveEmptyEntries);
            var regex = new Regex(@"^[a-zA-Z]\w{2,24}$");

            List<string> userNames = GetValidUsername(input, regex);
            HashSet<string> maxSumUsernames = GetMaxSumOfUsernames(userNames);

            Console.WriteLine(string.Join(Environment.NewLine, maxSumUsernames));
        }

        private static HashSet<string> GetMaxSumOfUsernames(List<string> userNames)
        {
            var maxSumUsernames = new HashSet<string>();

            var maxSum = int.MinValue;

            for (int i = 1; i < userNames.Count; i++)
            {
                var currentSum = userNames[i].Length + userNames[i - 1].Length;

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;

                    maxSumUsernames.Clear(); // clear all data in HashSet
                    maxSumUsernames.Add(userNames[i - 1]);
                    maxSumUsernames.Add(userNames[i]);
                }
            }
            return maxSumUsernames;
        }

        private static List<string> GetValidUsername(string[] input, Regex regex)
        {
            var usernames = new List<string>();

            foreach (var username in input)
            {
                if (regex.IsMatch(username))
                {
                    usernames.Add(username);
                }
            }

            return usernames;
        }
    }
}
