using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Inferno_III
{
    class Program
    {
        private static List<int> gems;

        static void Main(string[] args)
        {
            var dataCommands = new Dictionary<string, Dictionary<int, Predicate<int>>>();

            gems = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            string command;

            while ((command = Console.ReadLine()) != "Forge")
            {
                var tokens = command
                    .Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

                var action = tokens[0];
                var filterType = tokens[1];
                var filterParams = int.Parse(tokens[2]);

                if (action == "Exclude")
                {
                    var filterFunc = GetFunc(filterType, filterParams);

                    if (!dataCommands.ContainsKey(filterType))
                    {
                        dataCommands[filterType] = new Dictionary<int, Predicate<int>>();
                    }

                    dataCommands[filterType].Add(filterParams, filterFunc);
                }
                else if (action == "Reverse")
                {
                    dataCommands[filterType].Remove(filterParams);
                }
            }

            gems = GetFiltredGems(dataCommands);
            Console.WriteLine(string.Join(" ", gems));
        }

        private static List<int> GetFiltredGems(Dictionary<string, Dictionary<int, Predicate<int>>> dataCommands)
        {
            var result = new List<int>();

            for (var i = 0; i < gems.Count; i++)
            {
                var isFiltred = false;

                foreach (var filter in dataCommands)
                {
                    foreach (var predicate in filter.Value)
                    {
                        if (predicate.Value(i))
                        {
                            isFiltred = true;
                            break;
                        }
                    }
                }
                if (!isFiltred)
                {
                    result.Add(gems[i]);
                }
            }
            return result;
        }

        private static Predicate<int> GetFunc(string filterType, int filterParams)
        {
            switch (filterType)
            {
                case "Sum Left":
                    return i => 
                    (i <= 0 ? 0 : gems[i - 1])
                    + gems[i]
                    == filterParams;

                case "Sum Right":
                    return i => 
                    (i >= gems.Count - 1 ? 0 : gems[i + 1])
                    + gems[i]
                    == filterParams;

                case "Sum Left Right":
                    return i => 
                    (i <= 0 ? 0 : gems[i - 1])
                    + (i >= gems.Count - 1 ? 0 : gems[i + 1])
                    + gems[i] == filterParams;
            }
            return null;
        }
    }
}
