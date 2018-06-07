using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_LegendaryFarming
{
    class LegendaryFarming
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, int> data = new SortedDictionary<string, int>();
            Dictionary<string, int> keyMaterialsData = new Dictionary<string, int>()
            {
                {"shards", 0}, {"fragments", 0}, {"motes", 0}
            };
            string[] legendaryItems = new string[] { "Shadowmourne", "Valanyr", "Dragonwrath" };
            string keyMaterial = string.Empty;
            bool isObtained = true;

            while (isObtained)
            {
                var inputLine = Console.ReadLine().ToLower().Split();

                for (int i = 0; i < inputLine.Length; i += 2)
                {
                    int quantity = int.Parse(inputLine[i]);
                    string material = inputLine[i + 1];

                    if (material == "shards" || material == "fragments" || material == "motes")
                    {
                        keyMaterialsData[material] += quantity;
                    }
                    else
                    {
                        if (!data.ContainsKey(material))
                        {
                            data[material] = quantity;
                        }
                        else
                        {
                            data[material] += quantity;
                        }
                    }

                    if (keyMaterialsData.ContainsKey(material) && keyMaterialsData[material] >= 250)
                    {
                        keyMaterialsData[material] -= 250;
                        keyMaterial = material;
                        isObtained = false;
                        break;
                    }
                }

            }

            switch (keyMaterial)
            {
                case "fragments":
                    Console.WriteLine("Valanyr obtained!");
                    break;
                case "shards":
                    Console.WriteLine("Shadowmourne obtained!");
                    break;
                case "motes":
                    Console.WriteLine("Dragonwrath obtained!");
                    break;
            }

            foreach (var kvp in keyMaterialsData.OrderByDescending(v => v.Value).ThenBy(k => k.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            foreach (var kvp in data)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

        }
    }
}
