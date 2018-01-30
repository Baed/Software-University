using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Triangle_of_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            /*
            for (int row = 1; row <= n; row++) // pri 6
            {
                for (int col = 0; col < row; col++) // + 5 $ na red
                {
                    Console.Write("$ ");
                }
                Console.WriteLine();
                */

            // vtori nachin
            for (int row = 1; row <= n; row++) // pri 6
            {
                string dollars = "";
                for (int col = 0; col < row; col++) // + 5 $ na red
                {
                    dollars += "$ ";
                }

                Console.WriteLine(dollars);

            }
        }
    }
}
