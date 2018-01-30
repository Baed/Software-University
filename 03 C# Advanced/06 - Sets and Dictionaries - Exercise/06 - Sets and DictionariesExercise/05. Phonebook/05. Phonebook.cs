using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, string>();

            string input = Console.ReadLine();

            while (input != "search")
            {
                if (input.Length > 1)
                {
                    var tokens = input.Trim().Split(new[] { '-', }, StringSplitOptions.RemoveEmptyEntries);
                    var name = tokens[0];
                    var phoneNum = tokens[1];
                    if (!data.ContainsKey(name))
                    {
                        data.Add(name, phoneNum);
                    }
                    data[name] = phoneNum;
                }
                input = Console.ReadLine();
            }

            string names = Console.ReadLine();

            while (names != "stop")
            {
                if (data.ContainsKey(names))
                {
                    Console.WriteLine($"{names} -> {data[names]}");
                }
                else
                {
                    Console.WriteLine($"Contact {names} does not exist.");
                }
                names = Console.ReadLine();
            }
        }
    }
}

