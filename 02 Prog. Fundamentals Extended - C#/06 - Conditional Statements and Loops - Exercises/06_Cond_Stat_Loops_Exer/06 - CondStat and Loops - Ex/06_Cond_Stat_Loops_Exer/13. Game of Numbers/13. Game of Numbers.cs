using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magic = int.Parse(Console.ReadLine());

            var ctr = 0;
            var matchCtr = 0;

            for (int i = m; i >= n; i--)
            {
                for (int j = m; j >= n; j--)
                {
                    ctr++;                   
                    if (i + j == magic)
                    {
                        Console.WriteLine($"Number found! {i} + {j} = {magic}");
                        matchCtr++;
                        return;
                    }
                }
            }
            if (matchCtr == 0)
            {
                Console.WriteLine($"{ctr} combinations - neither equals 100");
            }              
        }
    }
}
