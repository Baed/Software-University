using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Icarus
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> initialList = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            int index = int.Parse(Console.ReadLine());

            int damage = 1;

            string command;
            while ((command = Console.ReadLine()) != "Supernova")
            {
                var cmdArgs = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int length = int.Parse(cmdArgs[1]);

                switch (cmdArgs[0])
                {
                    case "left":
                        for (int i = 0; i < length; i++)
                        {
                            index--;

                            if (index < 0)
                            {
                                index = initialList.Count - 1;

                                damage++;
                            }

                            initialList[index] -= damage;
                        }
                        break;

                    case "right":
                        for (int i = 0; i < length; i++)
                        {
                            index++;

                            if (index > initialList.Count - 1)
                            {
                                index = 0;

                                damage++;
                            }

                            initialList[index] -= damage;
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", initialList));
        }
    }
}
