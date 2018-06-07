using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Array__Equal_to_Their_Index
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrNum = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string result = "";
            int cntLength = 0;
            for (int i = 0; i < arrNum.Length; i++)
            {                
                if (arrNum[i] == cntLength)
                {                   
                    result += arrNum[i] + " ";                    
                }
                cntLength++;
            }
            Console.WriteLine(result);
        }
    }
}
