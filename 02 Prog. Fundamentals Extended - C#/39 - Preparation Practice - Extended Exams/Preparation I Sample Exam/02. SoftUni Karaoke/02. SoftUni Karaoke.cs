using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SoftUni_Karaoke
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] participants = Console.ReadLine().Split(',').Select(p => p.Trim()).ToArray();
            string[] availableSongs = Console.ReadLine().Split(',').Select(a => a.Trim()).ToArray();

            Dictionary<string, List<string>> karaokeData = new Dictionary<string, List<string>>();

            string command = Console.ReadLine();

            while (command != "dawn")
            {
                string[] tokens = command.Split(',').Select(t => t.Trim()).ToArray();
                // Vankata, Dragana - Kukavice, Best Srabsko

                string singer = tokens[0];   // Vankata,
                string song = tokens[1];     // Dragana - Kukavice,
                string award = tokens[2];    // Best Srabsko

                if (participants.Contains(singer) && availableSongs.Contains(song))
                {
                    if (!karaokeData.ContainsKey(singer))
                    {
                        karaokeData.Add(singer, new List<string>());
                        // karaokeData[singer] = new List<string>()
                    }

                    List<string> awards = karaokeData[singer];

                    if (!awards.Contains(award))
                    {
                        awards.Add(award);
                    }
                }
                command = Console.ReadLine();
            }

            if (karaokeData.Any())
            {
                foreach (var singer in karaokeData.OrderByDescending(award => award.Value.Count).ThenBy(name => name.Key))
                {
                    Console.WriteLine($"{singer.Key}: {singer.Value.Count} awards");
                    List<string> awards = singer.Value;

                    foreach (var award in awards.OrderBy(award => award)) // Print unique awards for every participant sorted alphabetically
                    {
                        Console.WriteLine($"--{award}");
                    }
                }
            }
            else
            {
                Console.WriteLine("No awards");
            }
        }
    }
}
