using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shoot_List_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<int> number = new List<int>();

            int lastShotNumber = 0;

            while (true)
            {
                if (input == "bang")
                {
                    if (number.Count == 0)
                    {
                        Console.WriteLine($"nobody left to shoot! last one was {lastShotNumber}");
                        break;
                    }
                    double average = number.Average();
                    for (int i = 0; i < number.Count; i++)
                    {
                        if (number[i] < average)
                        {
                            lastShotNumber = number[i];
                            number.RemoveAt(i);
                            Console.WriteLine($"shot {lastShotNumber}");
                            break;
                        }
                        else if (number.Count == 1)
                        {
                            lastShotNumber = number[i];
                            number.RemoveAt(i);
                            Console.WriteLine($"shot {lastShotNumber}");
                            break;
                        }
                    }
                    for (int i = 0; i < number.Count; i++)
                    {
                        number[i]--;
                    }
                }
                else if (input == "stop")
                {
                    if (number.Count == 0)
                    {
                        Console.WriteLine($"you shot them all. last one was {lastShotNumber}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"survivors: {string.Join(" ", number)}");
                        break;
                    }
                }
                else
                {
                    int n = int.Parse(input);
                    number.Insert(0, n);
                }

                input = Console.ReadLine();
            }
        }
    }
}
