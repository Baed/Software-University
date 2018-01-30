using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Note_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> initialsNotes = new List<string>(new string[]
            {
                "C",
                "C#",
                "D",
                "D#",
                "E",
                "F",
                "F#",
                "G",
                "G#",
                "A",
                "A#",
                "B"
            });
            List<double> initialsFrequencies = new List<double>(new double[]
            {
                  261.63,
                  277.18,
                  293.66,
                  311.13,
                  329.63,
                  349.23,
                  369.99,
                  392.00,
                  415.30,
                  440.00,
                  466.16,
                  493.88
            });

            List<double> frequencies = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            List<string> totalNotes = new List<string>();
            List<string> naturalsNotes = new List<string>();
            List<string> sharpsNotes = new List<string>();

            double naturalSum = 0;
            double sharpsSum = 0;

            for (int i = 0; i < frequencies.Count; i++)
            {
                double currentFrequency = frequencies[i];
                int index = initialsFrequencies.IndexOf(currentFrequency);
                string currentNote = initialsNotes[index];
                // IndexOf --> ako elementa se sudurja v masiva mi dai negoviq index
                if (IsNatural(currentNote))
                {
                    naturalsNotes.Add(currentNote);
                    naturalSum += currentFrequency;
                }
                else
                {
                    sharpsNotes.Add(currentNote);
                    sharpsSum += currentFrequency;
                }
                totalNotes.Add(currentNote);
            }
            Console.WriteLine($"Notes: {string.Join(" ", totalNotes)}");
            Console.WriteLine($"Naturals: {string.Join(", ", naturalsNotes)}");
            Console.WriteLine($"Sharps: {string.Join(", ", sharpsNotes)}");
            Console.WriteLine($"Naturals sum: {naturalSum}");
            Console.WriteLine($"Sharps sum: {sharpsSum}");
        }

        static bool IsNatural(string currentNote)
        {
            return (currentNote.Length == 1);
        }
    }
}
