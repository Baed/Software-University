using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.A_Miner_s_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, int>();

            while (true)
            {
                string resources = Console.ReadLine();

                if (resources.ToLower() == "stop")
                {
                    break;
                }

                int quantity = int.Parse(Console.ReadLine());

                if (!data.ContainsKey(resources))
                {
                    data.Add(resources, 0);
                }
                data[resources] += quantity;
            }

            foreach (var item in data)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
