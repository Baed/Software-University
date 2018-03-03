using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace _04._01_Pokemon_Evo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<Pokemon>> data = new Dictionary<string, List<Pokemon>>();

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
                    long score = long.Parse(cmdArgs[2]);

                    Pokemon pokemon = new Pokemon(type, score);

                    if (!data.ContainsKey(name))
                    {
                        data.Add(name, new List<Pokemon>());
                    }

                    data[name].Add(pokemon);
                }
            }

            Printer(data);
        }

        private static void Printer(Dictionary<string, List<Pokemon>> data)
        {
            foreach (var pokemon in data)
            {
                Console.WriteLine($"# {pokemon.Key}");

                foreach (var kvp in pokemon.Value.OrderByDescending(e => e.Score))
                {
                    Console.WriteLine($"{kvp.Type} <-> {kvp.Score}");
                }
            }
        }

        private static void SpecialCasePrinter(Dictionary<string, List<Pokemon>> data, string name)
        {
            foreach (var pokemon in data.Where(p => p.Key.Contains(name)))
            {
                Console.WriteLine($"# {pokemon.Key}");

                foreach (var kvp in pokemon.Value)
                {
                    Console.WriteLine($"{kvp.Type} <-> {kvp.Score}");
                }
            }
        }
    }

    class Pokemon
    {
        public Pokemon(string type, long score)
        {
            Type = type;
            Score = score;
        }

        public string Type { get; set; }

        public long Score { get; set; }
    }
}
