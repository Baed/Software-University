using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Trainegram
{
    class Program
    {
        static void Main(string[] args)
        {          
            while (true)
            {
                string message = Console.ReadLine();

                Regex regex = new Regex(@"^<\[([^a-zA-Z0-9]*)\]\.(\.\[([a-zA-Z0-9]*)\]\.)*$");
                // pattern = @"(^<\[[^A-Za-z0-9]*?\]\.)(\.\[[A-Za-z0-9]*?\]\.)*?$";
                // pattern = @"^(\<\[[^A-Za-z0-9]*\][\.]{1})+([\.]{1}\[[A-Za-z0-9]*\][\.]{1})*$";
                Match match = regex.Match(message);

                if (match.Success)
                {
                    Console.WriteLine(match.Value);
                }
                if (message == "Traincode!")
                {
                    return;
                }
            }
        }
    }
}
