using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._03_Track_Downloader
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedSongs = Console.ReadLine().Split(' ');
            string song = Console.ReadLine();
            List<string> playlist = new List<string>();
            while (song != "end")
            {
                bool isContained = false;
                for (int i = 0; i < bannedSongs.Length; i++)
                {
                    if (song.Contains(bannedSongs[i]))
                    {
                        isContained = true;
                    }
                }
                if (!isContained)
                {
                    playlist.Add(song);
                }
                song = Console.ReadLine();
            }
            playlist.Sort();
            Console.WriteLine(string.Join("\n", playlist));
        }
    }
}
