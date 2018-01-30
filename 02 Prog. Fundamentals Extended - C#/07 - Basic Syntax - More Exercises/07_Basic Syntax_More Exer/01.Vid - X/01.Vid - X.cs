using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Vid___X
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //var left = 0;
            //var right = num - 1;
            for (int row = 0; row < n; ++row)
            {
                for (int col = 0; col < n; ++col)
                {
                    if (row == col) // (col == left) || (col == right) 
                    {
                        Console.Write('x');
                    }
                    else if (col == n - row - 1) // mahame
                    {
                        Console.Write('x');
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
                //left++;
                //right++;
            }
        }
    }
}
