using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03._01_Camera_view
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int skip = nums[0];
            int take = nums[1];

            string pattern = "\\|<(\\w{" + skip + "})(\\w{0," + take + "})";

            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, pattern);

            List<string> result = new List<string>();

            foreach (Match m in matches)
            {
                result.Add(m.Groups[2].Value);
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
