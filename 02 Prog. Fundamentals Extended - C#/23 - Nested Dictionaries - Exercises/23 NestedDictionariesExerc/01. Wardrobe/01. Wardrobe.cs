using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int cnt = int.Parse(Console.ReadLine());

            var wardrobe = new Dictionary<string, Dictionary<string, int>>(); 

            for (int i = 0; i < cnt; i++)
            {
                string[] tokens = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

                string color = tokens[0];

                string[] clothes = tokens[1].Split(',');

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }

                foreach (var itemCloth in clothes)
                {
                    // wardrobe[color] ===> vzemame value->clothes ot wardrobe(dict) sus key ->color
                    Dictionary<string, int> getClothes = wardrobe[color]; // getClothes ==> clothes

                    if (!getClothes.ContainsKey(itemCloth))
                    {
                        getClothes.Add(itemCloth, 0); // suzdavame dreha i pri vsqka iteraciq q uvelicavame
                    }

                    getClothes[itemCloth]++; // vzemame broikata (value)
                    
                }
            }

            string[] command = Console.ReadLine().Split(' ');
            string searchColor = command[0];
            string searchCloth = command[1];

            foreach (KeyValuePair<string, Dictionary<string, int>> colorItem in wardrobe)
            {
                var resultColor = colorItem.Key;

                Console.WriteLine("{0} clothes:", resultColor);

                Dictionary<string, int> resultCloth = colorItem.Value;
                foreach (KeyValuePair<string, int> clothItem in resultCloth)
                {
                    string cloth = clothItem.Key;
                    int quantity = clothItem.Value;

                    Console.Write("* {0} - {1} ", cloth, quantity); // pechata na sushtiq red
                    if (resultColor == searchColor && cloth == searchCloth)
                    {
                        Console.Write("(found!)");
                    }
                        Console.WriteLine();
                }
            }
        }
    }
}
