using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._01_PopulationCnt
{
    class PopulationCnt
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> data = new Dictionary<string, Dictionary<string, long>>();

            string input;
            while ((input = Console.ReadLine()) != "report")
            {
                var tokens = input.Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

                var city = tokens[0];
                var country = tokens[1];
                var population = long.Parse(tokens[2]);

                if (!data.ContainsKey(country))
                {
                    data.Add(country, new Dictionary<string, long>());
                }

                if (!data[country].ContainsKey(city))
                {
                    data[country].Add(city, 0);
                }

                data[country][city] += population;
            }

            foreach (var countr in data.OrderByDescending(c => c.Value.Values.Sum()))
            {
                Console.WriteLine($"{countr.Key} (total population: {countr.Value.Values.Sum()})");

                foreach (var cit in countr.Value.OrderByDescending(c => c.Value))
                {
                    Console.WriteLine($"=>{cit.Key}: {cit.Value}");
                }
            }
        }
    }
}
