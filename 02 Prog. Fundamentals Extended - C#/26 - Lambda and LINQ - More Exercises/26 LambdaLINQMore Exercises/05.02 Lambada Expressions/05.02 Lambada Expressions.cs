using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._02_Lambada_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> data = new Dictionary<string, string>();
            List<string> input = Console.ReadLine().Split(" =>".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();

            while (input[0] != "lambada")
            {
                if (input[0] != "dance")
                {
                    data[input[0]] = input[1];
                }
                if (input[0] == "dance")
                {
                    data = data.ToDictionary(x => x.Key, x => $"{x.Key}.{x.Value}");
                }

                input = Console.ReadLine().Split(" =>".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();
            }

            foreach (var item in data)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
