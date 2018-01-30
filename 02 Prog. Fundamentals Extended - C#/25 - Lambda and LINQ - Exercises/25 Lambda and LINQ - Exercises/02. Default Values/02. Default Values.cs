using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Default_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, string>();

            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] inputTokens =
                    input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

                string name = inputTokens[0];
                string value = inputTokens[1];

                data[name] = value;

                input = Console.ReadLine();
            }

            string defaultValue = Console.ReadLine();

            var nonDefaultValues = data
                .Where(r => r.Value != "null")
                .OrderByDescending(r => r.Value.Length);

            var defaultValues = data
                .Where(r => r.Value == "null")
                .Select(r => new KeyValuePair<string, string>(r.Key, defaultValue))
                .ToDictionary(r => r.Key, r => r.Value);

            foreach (var record in nonDefaultValues)
            {
                Console.WriteLine("{0} <-> {1}", record.Key, record.Value);
            }

            foreach (var record in defaultValues)
            {
                Console.WriteLine("{0} <-> {1}", record.Key, record.Value);
            }
        }
    }
}
