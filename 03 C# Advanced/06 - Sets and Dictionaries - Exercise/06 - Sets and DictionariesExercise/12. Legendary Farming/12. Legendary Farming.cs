using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            var junkMaterialsData = new Dictionary<string, int>();

            var keyMaterialsData = new Dictionary<string, int>();
            keyMaterialsData["shards"] = 0;
            keyMaterialsData["fragments"] = 0;
            keyMaterialsData["motes"] = 0;


            // Collect materials until reach the amount of 250 for some of the key materials
            GetCollectMaterials(keyMaterialsData, junkMaterialsData);

            // Print the legendary item
            Console.WriteLine($"{GetObtainLegendary(keyMaterialsData)} obtained!");

            // Print remaining key mateirals
            PrintMaterials(keyMaterialsData.OrderByDescending(q => q.Value).ThenBy(m => m.Key));

            // Print collected junk materials
            PrintMaterials(junkMaterialsData.OrderBy(m => m.Key));
        }

        private static void PrintMaterials(IOrderedEnumerable<KeyValuePair<string, int>> data)
        {
            foreach (var material in data)
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }
        }

        private static string GetObtainLegendary(Dictionary<string, int> keyMaterialsData)
        {
            var material = keyMaterialsData.Where(kvp => kvp.Value >= 250).First().Key;

            // Remove 250 from the amount to obtain the legendary item
            keyMaterialsData[material] -= 250;

            // Find which is the legendary item obtained
            switch (material)
            {
                case "shards": return "Shadowmourne";
                case "fragments": return "Valanyr";
                case "motes": return "Dragonwrath";
                default: return "Try Again bro!";
            }
        }

        private static void GetCollectMaterials(Dictionary<string, int> keyMaterialsData, Dictionary<string, int> junkMaterialsData)
        {
            while (true)
            {
                var input = Console.ReadLine()
                        .ToLower()
                        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < input.Length; i++)
                {
                    var quantity = int.Parse(input[i]); // 0
                    i++; // +
                    var material = input[i]; // => 1


                    if (keyMaterialsData.ContainsKey(material))
                    {
                        keyMaterialsData[material] += quantity;
                        if (keyMaterialsData[material] >= 250)
                        {
                            return; // to Private Main()
                        }
                    }
                    else
                    {
                        if (!junkMaterialsData.ContainsKey(material))
                        {
                            junkMaterialsData.Add(material, 0);
                        }
                        junkMaterialsData[material] += quantity;
                    }
                }
            }
        }
    }
}
