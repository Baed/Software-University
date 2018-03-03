using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._01_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, long> nameSize = new Dictionary<string, long>();

            int numberOfFiles = int.Parse(Console.ReadLine());

            string[] paths = new string[numberOfFiles];

            for (int i = 0; i < paths.Length; i++)
            {
                paths[i] = Console.ReadLine();
            }

            string query = Console.ReadLine();

            string extension = "." + query.Substring(0, query.IndexOf("in")).Trim();
            string root = query.Substring(query.IndexOf("in") + 2).Trim();

            foreach (string path in paths)
            {
                if (path.StartsWith(root))
                {
                    string fileName = path.Substring(path.LastIndexOf('\\') + 1);

                    long fileSize = long.Parse(fileName.Substring(fileName.LastIndexOf(';') + 1).Trim());

                    fileName = fileName.Remove(fileName.IndexOf(';')).Trim();

                    if (fileName.EndsWith(extension))
                    {
                        nameSize[fileName] = fileSize;
                    }
                }
            }

            if (nameSize.Count == 0)
            {
                Console.WriteLine("No");
            }

            else
            {
                foreach (var kvp in nameSize.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{kvp.Key} - {kvp.Value} KB");
                }
            }
        }
    }
}

