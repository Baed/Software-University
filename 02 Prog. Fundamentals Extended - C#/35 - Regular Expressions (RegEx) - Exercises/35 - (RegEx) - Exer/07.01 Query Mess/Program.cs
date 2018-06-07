using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _07._01_Query_Mess
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstPattern = @"([^&?]+)=([^&?]+)";

            var secondPatter = @"(%20|\+)+";

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                var matches = Regex.Matches(input, firstPattern);

                var dictionary = new Dictionary<string, List<string>>();

                for (int i = 0; i < matches.Count; i++)
                {
                    string field = matches[i].Groups[1].Value;
                    field = Regex.Replace(field, secondPatter, " ").Trim();

                    var value = matches[i].Groups[2].Value;
                    value = Regex.Replace(value, secondPatter, " ").Trim();

                    if (!dictionary.ContainsKey(field))
                    {
                        dictionary[field] = new List<string>();
                    }

                    dictionary[field].Add(value);
                }

                foreach (var kvpResult in dictionary)
                {
                    Console.Write($"{kvpResult.Key}=[{string.Join(", ", kvpResult.Value)}]");
                }

                Console.WriteLine();
            }
        }
    }
}
