using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Karaoke
{
    public Karaoke(string name)
    {
        Name = name;
        Songs = new List<string>();
        Awards = new List<string>();
    }

    public string Name { get; set; }

    public List<string> Songs { get; set; }

    public List<string> Awards { get; set; }
}

class SoftUniKaraoke
{
    static void Main()
    {
        List<Karaoke> karaokeList = new List<Karaoke>();

        string[] participants = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
        string[] availableSongs = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

        string command;
        while ((command = Console.ReadLine()) != "dawn")
        {
            string[] cmdArgs = command.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

            string participant = cmdArgs[0];
            string song = cmdArgs[1];
            string award = cmdArgs[2];

            if (!participants.Contains(participant) || !availableSongs.Contains(song)) continue;

            if (karaokeList.Any(x => x.Name == participant))
            {
                Karaoke karaoke = karaokeList.First(x => x.Name == participant);

                if (!karaoke.Songs.Contains(song) || !karaoke.Awards.Contains(award))
                {
                    karaoke.Songs.Add(song);

                    karaoke.Awards.Add(award);
                }
            }
            else
            {
                Karaoke karaoke = new Karaoke(participant);

                karaoke.Songs.Add(song);

                karaoke.Awards.Add(award);

                karaokeList.Add(karaoke);
            }
        }

        if (karaokeList.Count == 0)
        {
            Console.WriteLine("No awards");
        }

        foreach (Karaoke singer in karaokeList.OrderByDescending(x => x.Awards.Count).ThenBy(x => x.Name))
        {
            Console.WriteLine("{0}: {1} awards", singer.Name, singer.Awards.Count);

            foreach (string award in singer.Awards.OrderBy(x => x))
            {
                Console.WriteLine("--{0}", award);
            }
        }
    }
}
