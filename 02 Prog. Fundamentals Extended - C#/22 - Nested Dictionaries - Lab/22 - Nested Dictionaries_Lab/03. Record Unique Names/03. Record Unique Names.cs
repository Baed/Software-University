using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Record_Unique_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> names = new HashSet<string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                /*
                if (!names.Contains(name))
                {
                    names.Add(name);
                }
                // hashset pazi unikalni elemnti i ne e nujna proverkata
                */
                names.Add(name);
            }
            /*
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            */
            Console.WriteLine(string.Join("\n", names));
            //Console.WriteLine(string.Join(Environment.NewLine, names));
    
        }
    }
}
