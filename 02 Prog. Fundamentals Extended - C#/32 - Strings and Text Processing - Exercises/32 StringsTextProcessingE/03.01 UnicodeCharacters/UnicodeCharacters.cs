using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._01_UnicodeCharacters
{
    class UnicodeCharacters
    {
        static void Main(string[] args)
        {
            char[] word = Console.ReadLine().ToCharArray();

            StringBuilder solution = new StringBuilder();

            foreach (char c in word)
            {
                solution.AppendFormat("\\u{0:x4}", (int)c);
            }

            Console.WriteLine(solution);
        }
    }
}
