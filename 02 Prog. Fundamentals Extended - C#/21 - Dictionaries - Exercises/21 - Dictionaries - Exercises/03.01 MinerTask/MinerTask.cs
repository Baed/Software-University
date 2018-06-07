using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._01_MinerTask
{
    class MinerTask
    {
        static void Main(string[] args)
        {
            Dictionary<string, long> data = new Dictionary<string, long>();
            
            while (true)
            {
                string elements = Console.ReadLine();
                if (elements == "stop")
                {
                    break;
                }

                long quantity = long.Parse(Console.ReadLine());

                    if (!data.ContainsKey(elements))
                    {
                        data.Add(elements, 0);
                    }
                  
                    data[elements] += quantity;          
            }

            foreach (var item in data)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
