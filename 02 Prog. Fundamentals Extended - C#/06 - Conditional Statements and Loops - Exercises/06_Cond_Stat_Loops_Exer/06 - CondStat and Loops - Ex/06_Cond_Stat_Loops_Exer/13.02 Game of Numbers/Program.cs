using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._02_Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int ctr = 0;
            int LastI = 0;
            int LastJ = 0;
            bool combination = false;

            for (int i = n; i <= m; i++)
            {
                for (int j = n; j <= m; j++)
                {
                    ctr++;
                    if (i + j == magicNumber)
                    {
                        LastI = i;
                        LastJ = j;
                        combination = true;
                    }
                }
            }
            if (combination == true)
            {
                Console.WriteLine($"Number found! {LastI} + {LastJ} = {magicNumber}");
            }
            else
            {
                Console.WriteLine($"{ctr} combinations - neither equals {magicNumber}");
            }
        }
    }
}
