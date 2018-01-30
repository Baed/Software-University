using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Unique_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var username = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {

                string users = Console.ReadLine().Trim();
                username.Add(users);
            }
            Console.WriteLine(string.Join("\r\n", username));
        }
    }
}
