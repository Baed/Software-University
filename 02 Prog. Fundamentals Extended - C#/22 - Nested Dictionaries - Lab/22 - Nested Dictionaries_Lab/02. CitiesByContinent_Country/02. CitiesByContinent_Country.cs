using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CitiesByContinent_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            var globeMap = new Dictionary<string, Dictionary<string, List<string>>>();

            int counter = int.Parse(Console.ReadLine());

            for (int i = 0; i < counter; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                string continent = input[0];
                string country = input[1];
                string capital = input[2];

                if (!globeMap.ContainsKey(continent))
                {
                    globeMap.Add(continent, new Dictionary<string, List<string>>());
                }

                if (!globeMap[continent].ContainsKey(country))
                {
                    globeMap[continent].Add(country, new List<string>());
                }

                globeMap[continent][country].Add(capital);
            }

            foreach (var continentItem in globeMap)
            {
                string continentName = continentItem.Key;
                var countryAndCity = continentItem.Value;

                Console.WriteLine("{0}:", continentName);

                foreach (var countryItem in countryAndCity)
                {
                    string countryName = countryItem.Key;
                    List<string> capitalName = countryItem.Value;

                    Console.WriteLine("  {0} -> {1}", countryName, string.Join(", ", capitalName));
                }
            }
        }
    }
}
