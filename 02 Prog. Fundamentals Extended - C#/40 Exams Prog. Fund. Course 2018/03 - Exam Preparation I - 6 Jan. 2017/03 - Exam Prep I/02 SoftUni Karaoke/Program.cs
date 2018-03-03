using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_SoftUni_Karaoke
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Karaoke> karaokesList = new List<Karaoke>();

            List<string> participants = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> availableSongs = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();

            string command;
            while ((command = Console.ReadLine()) != "dawn")
            {
                var cmdArgs = command.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

                string participant = cmdArgs[0];
                string song = cmdArgs[1];
                string award = cmdArgs[2];

                if (!participants.Contains(participant) || !availableSongs.Contains(song))
                {
                    continue;
                }

                if (karaokesList.Any(k => k.Participant.Equals(participant)))
                {
                    Karaoke karaoke = karaokesList.FirstOrDefault(k => k.Participant.Equals(participant));

                    if (!karaoke.Song.Contains(song) || !karaoke.AwardName.Contains(award))
                    {
                        karaoke.Song.Add(song);
                        karaoke.AwardName.Add(award);
                    }
                }
                else
                {
                    Karaoke karaoke = new Karaoke(participant);

                    karaoke.Song.Add(song);
                    karaoke.AwardName.Add(award);

                    karaokesList.Add(karaoke);
                }
            }

            foreach (Karaoke singer in karaokesList.OrderByDescending(x => x.AwardName.Count).ThenBy(x => x.Participant))
            {
                Console.WriteLine("{0}: {1} awards", singer.Participant, singer.AwardName.Count);

                foreach (string award in singer.AwardName.OrderBy(x => x))
                {
                    Console.WriteLine("--{0}", award);
                }
            }

            if (karaokesList.Count == 0)
            {
                Console.WriteLine($"No awards");
            }
        }
    }

    class Karaoke
    {
        public Karaoke(string participant)
        {
            Participant = participant;
            Song = new List<string>();
            AwardName = new List<string>();
        }

        public string Participant { get; set; }

        public List<string> Song { get; set; }

        public List<string> AwardName { get; set; }

      //  public override string ToString()
      //  {
      //      StringBuilder sb = new StringBuilder();
      //
      //      sb.AppendLine($"{Participant}: {AwardName.Count} awards");
      //
      //      foreach (var award in AwardName.OrderBy(x => x))
      //      {
      //          sb.AppendLine($"--{award}");
      //      }
      //
      //      return sb.ToString().Trim();
      //  }
    }
}
