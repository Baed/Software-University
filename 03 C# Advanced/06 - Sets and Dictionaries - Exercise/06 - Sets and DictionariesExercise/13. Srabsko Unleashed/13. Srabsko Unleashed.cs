using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _13.Srabsko_Unleashed
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, Dictionary<string, long>>();

            GetCollectData(data);

            PrintResult(data);
        }

        private static void PrintResult(Dictionary<string, Dictionary<string, long>> data)
        {
            foreach (var venue in data)
            {
                Console.WriteLine(venue.Key);

                foreach (var artist in venue.Value.OrderByDescending(a => a.Value))
                {
                    Console.WriteLine($"#  {artist.Key} -> {artist.Value}");
                }
            }
        }

        private static void GetCollectData(Dictionary<string, Dictionary<string, long>> data)
        {
            string input = Console.ReadLine();

            var pattern = @"(?<artist>([a-zA-Z]+\s?){1,3}) @(?<venue>([A-Za-z]+\s?){1,3}) (?<price>\d+) (?<count>\d+)";
            var regex = new Regex(pattern);

            while (input != "End")
            {
                if (!regex.IsMatch(input))
                {
                    input = Console.ReadLine();
                    continue;
                }
                else
                {
                    var match = regex.Match(input);

                    string venue = match.Groups["venue"].Value;
                    string artist = match.Groups["artist"].Value;
                    int priceTicket = int.Parse(match.Groups["price"].Value);
                    long countTicket = long.Parse(match.Groups["count"].Value);

                    var totalMoney = priceTicket * countTicket;

                    if (!data.ContainsKey(venue))
                    {
                        data.Add(venue, new Dictionary<string, long>());
                    }
                    if (!data[venue].ContainsKey(artist))
                    {
                        data[venue].Add(artist, 0);
                    }
                    data[venue][artist] += totalMoney;

                    input = Console.ReadLine();
                }
            }
        }
    }
}
