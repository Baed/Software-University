using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _10.SrubskoUnleashed
{
    class SrubskoUnleashed
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, Dictionary<string, int>>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string pattern = @"(([A-Za-z]+\s){1,3})@(([A-Za-z]+\s){1,3})(\d+)\s(\d+)";

                if (Regex.IsMatch(input, pattern))
                {
                    var match = Regex.Match(input, pattern);

                    string singer = match.Groups[1].Value.Trim();
                    string album = match.Groups[3].Value.Trim();
                    int ticketPrice = int.Parse(match.Groups[5].Value);
                    int ticketCount = int.Parse(match.Groups[6].Value);

                    int totalPrise = ticketCount * ticketPrice;

                    if (!data.ContainsKey(album))
                    {
                        data.Add(album, new Dictionary<string, int>());
                    }
                    if (!data[album].ContainsKey(singer))
                    {
                        data[album].Add(singer, 0);
                    }

                    data[album][singer] += totalPrise;
                }
            }

            foreach (var kvp in data)
            {
                Console.WriteLine($"{kvp.Key}");

                foreach (var artist in kvp.Value.OrderByDescending(p => p.Value))
                {
                    Console.WriteLine($"#  {artist.Key} -> {artist.Value}");
                }
            }
        }
    }
}
