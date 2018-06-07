using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _02_SnowMen
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersData = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> loserData = new List<int>();

            while (numbersData.Count != 1)
            {
                for (int i = 0; i < numbersData.Count; i++)
                {
                    if (Math.Abs(loserData.Count - numbersData.Count) == 1)
                    {
                        continue;
                    }

                    if (loserData.Contains(i))
                    {
                        continue;
                    }

                    int attacker = i;
                    int target = ValidIndex(numbersData[attacker], numbersData.Count);
                    int difference = Math.Abs(attacker - target);

                    if (difference == 0)
                    {
                        Console.WriteLine($"{attacker} performed harakiri");
                        loserData.Add(attacker);
                        loserData = loserData.Distinct().ToList();
                    }

                    if (difference != 0 && difference % 2 == 0)
                    {
                        Console.WriteLine($"{attacker} x {target} -> {attacker} wins");
                        loserData.Add(target);
                        loserData = loserData.Distinct().ToList();
                    }

                    if (difference % 2 == 1)
                    {
                        Console.WriteLine($"{attacker} x {target} -> {target} wins");
                        loserData.Add(attacker);
                        loserData = loserData.Distinct().ToList();
                    }
                }

                foreach (var index in loserData.OrderByDescending(x => x).Distinct())
                {
                    numbersData.RemoveAt(index);
                }

                loserData.Clear();
            }
        }

        private static int ValidIndex(int index, int lenght)
        {
            if (index >= lenght)
            {
                index = index % lenght;
            }
            return index;
        }
    }
}

