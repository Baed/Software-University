using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Map_Districts
{
    class Program
    {
        static void Main(string[] args)
        {
            var townsPop = GetTownPop();

            long border = long.Parse(Console.ReadLine());

            var result = townsPop.ToDictionary(x => x.Key, x => x.Value.Sum());

            Console.WriteLine(string.Join("\r\n", townsPop
                .Where(kvp => result[kvp.Key] >= border)
                .OrderByDescending(kvp => result[kvp.Key])
                .Select(t => $"{t.Key}: {string.Join(" ", t.Value.OrderByDescending(n => n). Take(5))}")));
        }

        private static Dictionary<string, List<long>> GetTownPop()
        {
            var districts = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var townsPopData = new Dictionary<string, List<long>>();

            foreach (var district in districts)
            {
                var separatorIndex = district.IndexOf(':');

                var town = district.Substring(0, separatorIndex);

                var currentPop = int.Parse(district.Substring(separatorIndex + 1));

                if (!townsPopData.ContainsKey(town))
                {
                    townsPopData[town] = new List<long>();
                }
                townsPopData[town].Add(currentPop);
            }
            return townsPopData;
        }
    }
}
