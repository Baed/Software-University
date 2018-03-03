using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CODE_Phoenix
{
    class Program
    {
        static void Main(string[] args)
        {
            var creatures = new Dictionary<string, HashSet<string>>();

            string input = Console.ReadLine();
            while (input != "Blaze it!")
            {
                string[] commands = input.Split(new string[] { " -> " }, StringSplitOptions.None);

                string creature = commands[0];
                string mate = commands[1];

                if (creature == mate)
                {
                    input = Console.ReadLine();
                    continue;
                }

                if (!creatures.ContainsKey(creature))
                {
                    creatures.Add(creature, new HashSet<string>());
                }

                if (!creatures[creature].Contains(mate))
                {
                    creatures[creature].Add(mate);
                }

                input = Console.ReadLine();
            }

            var counts = new Dictionary<string, int>();

            foreach (var creature in creatures)
            {
                int count = 0;

                foreach (var mate in creature.Value)
                {
                    if (!creatures.Keys.Contains(mate) || !creatures[mate].Contains(creature.Key))
                    {
                        count += 1;
                    }
                }

                counts.Add(creature.Key, count);
            }

            foreach (var creature in counts.OrderByDescending(x => x.Value))
            {
                Console.WriteLine("{0} : {1}", creature.Key, creature.Value);
            }
        }
    }
}
