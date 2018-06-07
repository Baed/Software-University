using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Cubic_Artillery
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());

            var bunkers = new Queue<string>();
            var weapons = new Queue<int>();

            var leftCapacity = capacity;

            string input;
            while ((input = Console.ReadLine()) != "Bunker Revision")
            {
                var tokens = input.Split(' ');

                foreach (var element in tokens)
                {
                    int weapon;
                    var isDigit = int.TryParse(element, out weapon);

                    if (!isDigit)
                    {
                        bunkers.Enqueue(element);
                    }
                    else
                    {
                        var isSaved = false;

                        while (bunkers.Count > 1)
                        {
                            if (leftCapacity >= weapon)
                            {
                                weapons.Enqueue(weapon);
                                leftCapacity -= weapon;

                                isSaved = true;
                                break;
                            }

                            var removedBunker = bunkers.Dequeue();

                            if (weapons.Count == 0)
                            {
                                Console.WriteLine($"{removedBunker} -> Empty");
                            }
                            else
                            {
                                Console.WriteLine($"{removedBunker} -> {string.Join(", ", weapons)}");
                            }

                            weapons.Clear();
                            leftCapacity = capacity;
                        }

                        if (!isSaved)
                        {
                            if (weapon <= capacity)
                            {
                                while (leftCapacity < weapon)
                                {
                                    leftCapacity += weapons.Dequeue();
                                }

                                weapons.Enqueue(weapon);
                                leftCapacity -= weapon;
                            }
                        }
                    }
                }
            }
        }
    }
}
