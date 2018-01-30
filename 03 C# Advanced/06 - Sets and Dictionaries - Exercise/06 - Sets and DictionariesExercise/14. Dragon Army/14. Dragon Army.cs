using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Dragon_Army
{
    class Program
    {
        private const int DefaltDamage = 45;
        private const int DefaltHealth = 250;
        private const int DefaltArmor = 10;

        static void Main(string[] args)
        {
            var data = new Dictionary<string, SortedDictionary<string, int[]>>();

            GetCollectData(data);
            PrintResult(data);
        }
        
        private static void PrintResult(Dictionary<string, SortedDictionary<string, int[]>> data)
        {
            foreach (var color in data)
            {
                Console.WriteLine($"{color.Key}::"
                    + $"({color.Value.Select(d => d.Value[0]).Average():f2}/"
                    + $"{color.Value.Select(h => h.Value[1]).Average():f2}/"
                    + $"{color.Value.Select(a => a.Value[2]).Average():f2})");

                foreach (var name in color.Value)
                {
                    Console.WriteLine($"-{name.Key} -> damage: {name.Value[0]}, health: {name.Value[1]}, armor: {name.Value[2]}");
                }
            }
        }

        private static void GetCollectData(Dictionary<string, SortedDictionary<string, int[]>> data)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string colorType = tokens[0];
                string name = tokens[1];
                var dragonDamage = tokens[2].Equals("null") ? DefaltDamage : int.Parse(tokens[2]);
                var dragonHealth = tokens[3].Equals("null") ? DefaltHealth : int.Parse(tokens[3]);
                var dragonArmor = tokens[4].Equals("null") ? DefaltArmor : int.Parse(tokens[4]);

                if (!data.ContainsKey(colorType))
                {
                    data.Add(colorType, new SortedDictionary<string, int[]>());
                }
                if (!data[colorType].ContainsKey(name))
                {
                    data[colorType].Add(name, new int[] { dragonDamage, dragonHealth, dragonArmor });
                }
                data[colorType][name] = new[] { dragonDamage, dragonHealth, dragonArmor };
            }
        }
    }
}
