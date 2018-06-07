using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.DNA_Sequences
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            var firstAndLast = "";

            for (int i = 1; i <= 4; i++)
            {
                for (int k = 1; k <= 4; k++)
                {
                    for (int j = 1; j <= 4; j++)
                    {
                        if (n <= i + k + j) { firstAndLast = "O"; }
                        else { firstAndLast = "X"; }
                        //var firstChar = i == 1 ? "A" : i == 2 ? "C" : i == 3 ? "G" : "T";
                        var char1 = "";
                        if (i == 1) { char1 ="A"; }
                        if (i == 2) { char1 = "C"; }
                        if (i == 3) { char1 = "G"; }
                        if (i == 4) { char1 = "T"; }
                        var char2 = "";
                        if (k == 1) { char2 = "A"; }
                        if (k == 2) { char2 = "C"; }
                        if (k == 3) { char2 = "G"; }
                        if (k == 4) { char2 = "T"; }
                        var char3 = "";
                        if (j == 1) { char3 = "A"; }
                        if (j == 2) { char3 = "C"; }
                        if (j == 3) { char3 = "G"; }
                        if (j == 4) { char3 = "T"; }
                        Console.Write($"{firstAndLast}{char1}{char2}{char3}{firstAndLast} ");                       
                    }
                    Console.WriteLine();
                }               
            }            
        }
    }
}
