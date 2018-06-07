using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Pokemon_Evolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<long>>> data = new Dictionary<string, Dictionary<string, List<long>>>();

            string command;
            while ((command = Console.ReadLine()) != "wubbalubbadubdub")
            {
                var cmdArgs = command.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

                string name = cmdArgs[0];

                if (cmdArgs.Length == 1)
                {
                    if (data.ContainsKey(name))
                    {
                        SpecialCasePrinter(data, name);
                    }
                }
                else
                {
                    string type = cmdArgs[1];
                    long index = long.Parse(cmdArgs[2]);

                    if (!data.ContainsKey(name))
                    {
                        data.Add(name, new Dictionary<string, List<long>>());
                    }

                    if (!data[name].ContainsKey(type))
                    {
                        data[name].Add(type, new List<long>());
                    }

                    data[name][type].Add(index);
                }
            }

            Printer(data);
        }

        public static void SpecialCasePrinter(Dictionary<string, Dictionary<string, List<long>>> data, string name)
        {
            Console.WriteLine($"# {name}");

            foreach (var pokemon in data.Where(p => p.Key.Contains(name)))
            {
                foreach (var kvp in pokemon.Value)
                {
                    foreach (var list in kvp.Value)
                    {
                        Console.WriteLine(kvp.Key + " <-> " + list);
                    }
                }
            }
        }

        public static void Printer(Dictionary<string, Dictionary<string, List<long>>> data)
        {
            foreach (var pokemon in data)
            {
                Console.WriteLine("# " + pokemon.Key);

                foreach (var kvp in pokemon.Value)
                {
                    foreach (var list in kvp.Value.OrderByDescending(x => x).ToList())
                    {
                        Console.WriteLine(kvp.Key + " <-> " + list);
                    }
                }
            }

        }
    }
}
