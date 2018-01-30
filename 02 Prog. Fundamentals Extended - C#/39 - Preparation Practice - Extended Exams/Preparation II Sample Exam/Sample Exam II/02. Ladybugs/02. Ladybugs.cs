using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());

            int[] indexes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] field = new int[fieldSize];
            
            foreach (var index in indexes
                .Where(a => a >= 0 && a < fieldSize).ToArray()) // if (index < 0 || index >= fieldSize) { continue }
            {
                field[index] = 1; // 0 i 1 --> ima kalinka => ravno na 1
            }       

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }

                string[] tokens = command.Split(' ');

                int ladyBugIndex = int.Parse(tokens[0]);
                string direction = tokens[1];
                int length = int.Parse(tokens[2]);

                if (ladyBugIndex < 0 || ladyBugIndex >= fieldSize)
                {
                    continue;
                }
                if (field[ladyBugIndex] == 0)
                {
                    continue;
                }

                int currentIndex = ladyBugIndex;
                field[ladyBugIndex] = 0;

                while (true)
                {
                    switch (direction)
                    {
                        case "right": currentIndex += length; break;

                        case "left": currentIndex -= length; break;
                    }
                    if (currentIndex < 0 || currentIndex >= fieldSize)
                    {
                        break;
                    }
                    if (field[currentIndex] != 1) // zashtoto field[index] = 1; tam kudeto e kacnala e razlicno ot 1;
                    {
                        field[currentIndex] = 1;
                        break;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", field));
        }
    }
}
