using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            for (char letter = 'a'; letter <= 'z'; letter++)
            {
                Console.WriteLine(letter);
            }
            */
            for (int i = 97; i < 122; i++) // ASCII - tablica v neta sim
                //for (int 'a' = 0; 'a' < 122; 'a'++)
                
            {
                Console.WriteLine((char)i); // cast - vzima kato int i q preprawq
            }
        }
    }
}
