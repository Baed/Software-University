using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06._01_Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split("\\ /()".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();

            string pattern = @"^[a-zA-Z][a-zA-Z\d_]{2,24}$";

            List<string> validUsernames = new List<string>();

            foreach (string username in input)
            {
                Match match = Regex.Match(username, pattern);

                if (match.Success)
                {
                    validUsernames.Add(username);
                }
            }

            int maxLength = 0;
            int bestIndex = 0;

            for (int i = 0; i < validUsernames.Count - 1; i++)
            {
                if ((validUsernames[i].Length + validUsernames[i + 1].Length) > maxLength)
                {
                    maxLength = validUsernames[i].Length + validUsernames[i + 1].Length;
                    bestIndex = i;
                }
            }

            Console.WriteLine(validUsernames[bestIndex]);
            Console.WriteLine(validUsernames[bestIndex + 1]);
        }
    }
}
