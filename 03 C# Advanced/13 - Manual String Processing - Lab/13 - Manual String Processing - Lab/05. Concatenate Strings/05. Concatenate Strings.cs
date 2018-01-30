using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Concatenate_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var builder = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                builder.Append(Console.ReadLine() + " ");            
            }

            Console.WriteLine(builder.ToString());
        }
    }
}
