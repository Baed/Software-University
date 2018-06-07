using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Population_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, Dictionary<string, long>>();
            var input = Console.ReadLine();

            while (input != "report")
            {
                var tokens = input.Split('|');

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

                input = Console.ReadLine();
            }

            foreach (var coutry in data.OrderByDescending(coutry => coutry.Value.Values.Sum()))
            {
                Console.WriteLine($"{coutry.Key} (total population: {coutry.Value.Values.Sum()})");

                foreach (var city in coutry.Value.OrderByDescending(city => city.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}
