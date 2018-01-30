using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.JSON_Stringify
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder builder = new StringBuilder();

            builder.Append("[");

            while (input != "stringify")
            {
                string[] tokens = input.Split(new string[] { " : ", " ->" }, StringSplitOptions.RemoveEmptyEntries);

                string name = tokens[0];
                string age = tokens[1];
                string[] grades = new string[] { };

                if (tokens.Length > 2)
                {
                    grades = tokens[2].Split(new string[] { ", ", " " }, StringSplitOptions.RemoveEmptyEntries);

                }

                //builder.Append("{");
                builder.Append(string.Format("{{name:\"{0}\",age:{1},grades:[{2}]}},", name, age, string.Join(", ", grades)));
                //builder.Append("}");

                input = Console.ReadLine();
            }

            builder.Remove(builder.Length - 1, 1); // premahvane na polsednata zapetaq
            builder.Append("]");

            Console.WriteLine(builder.ToString());
        }
    }
}
