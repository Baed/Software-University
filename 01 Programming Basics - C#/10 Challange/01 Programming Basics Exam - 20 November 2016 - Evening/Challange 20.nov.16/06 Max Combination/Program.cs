using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Max_Combination
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int combination = int.Parse(Console.ReadLine());
            
            var combination_cuurent = 0;

            for (int i = start; i <= end; i++)
            {
                
                for (int j = start; j <= end; j++)
                {
                    combination_cuurent++;
                    if (combination_cuurent > combination)
                    {
                        break;
                    }
                    
                    Console.Write("<{0}-{1}>", i, j);                                     
                }
            }
        }
    }
}
