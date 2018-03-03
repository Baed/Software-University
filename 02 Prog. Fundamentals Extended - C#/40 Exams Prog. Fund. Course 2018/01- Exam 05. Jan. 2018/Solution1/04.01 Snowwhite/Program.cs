using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._01_Snowwhite
{
    public class Program
    {

        static void Main(string[] args)
        {
            var data = new Dictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();

            while (input != "Once upon a time")
            {
                var dwarfInfo = input.Split(" <:> ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();

                string color = dwarfInfo[1];
                string name = dwarfInfo[0];
                int physics = int.Parse(dwarfInfo[2]);

                if (!data.ContainsKey(color))
                {
                    data.Add(color, new Dictionary<string, int>());
                    data[color][name] = physics;
                }

                if (!data[color].ContainsKey(name))
                {
                    data[color].Add(name, physics);
                }

                if (data[color][name] < physics)
                {
                    data[color][name] = physics;
                }

                input = Console.ReadLine();
            }

            foreach (var color in data.OrderByDescending(x => x.Value.Values.Max()).ThenByDescending(x => x.Key.GroupBy(n => n).Count()))
            {
                foreach (var dwarf in color.Value)
                {
                    Console.WriteLine($"({color.Key}) {dwarf.Key} <-> {dwarf.Value}");
                }
            }
        }
    }
}
