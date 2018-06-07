using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Lambada_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, Dictionary<string, string>>();

            string input = Console.ReadLine();

            while (input != "lambada")
            {
                string[] tokens = input.Split(new string[] { " => ", "." }, StringSplitOptions.RemoveEmptyEntries);

                if (tokens[0] == "dance")
                {
                   data =
                        data
                        .ToDictionary(
                        selector => selector.Key,
                        selector => selector.Value.ToDictionary(
                        selectorObject => selectorObject.Key,
                        selectorObject => selectorObject.Key 
                        + "."
                        + selectorObject.Value));
                }
                else
                {
                    string selector = tokens[0];
                    string selectorObject = tokens[1];
                    string selectorProperty = tokens[2];

                    if (!data.ContainsKey(selector))
                    {
                        data.Add(selector, new Dictionary<string, string>());
                    }

                    data[selector][selectorObject] = selectorProperty;
                }

                input = Console.ReadLine();
            }

            foreach (var item in data)
            {
                string selector = item.Key;
                Dictionary<string,string> selectorObjectData = item.Value;

                foreach (var subItem in selectorObjectData)
                {
                    string subSelector = subItem.Key;
                    string subProperty = subItem.Value;

                    Console.WriteLine("{0} => {1}.{2}", selector, subSelector, subProperty);
                }
            }
        }
    }
}
