using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03._02_Trainegram
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^<\[([^a-zA-Z0-9]*)\]\.(\.\[([a-zA-Z0-9]*)\]\.)*$";
            // string pattern = @"(^<\[[^A-Za-z0-9]*?\]\.)(\.\[[A-Za-z0-9]*?\]\.)*?$";
            // string pattern = @"^(\<\[[^A-Za-z0-9]*\][\.]{1})+([\.]{1}\[[A-Za-z0-9]*\][\.]{1})*$";

            while (true)
            {
                string composition = Console.ReadLine();
                Match match = Regex.Match(composition, pattern);
                if (match.Success)
                {
                    Console.WriteLine(match.Value);
                }
                if (composition == "Traincode!")
                {
                    return;
                }
            }
        }
    }
}
