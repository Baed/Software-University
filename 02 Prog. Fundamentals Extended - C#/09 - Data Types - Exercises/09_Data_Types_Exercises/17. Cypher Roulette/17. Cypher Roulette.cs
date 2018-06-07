using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Cypher_Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isReversed = false;
            string message = "";
            string prevString = "";

            for (int i = 0; i < n; i++)
            {
                string currentString = Console.ReadLine();
                if (currentString == prevString)
                {
                    message = "";
                    if (currentString == "spin") // ako sa dve ednakvi edno sled drugo
                    {
                        n++;
                    }                    
                }
                else
                {
                    if (currentString == "spin")
                    {
                        isReversed = !isReversed; //isReversed = true; ne e korektno
                        n++; // or i--;
                    }
                    else
                    {
                        if (isReversed)
                        {
                            message = currentString + message;
                        }
                        else
                        {
                            message += currentString;
                        }
                    }
                }
                prevString = currentString;
            }
            Console.WriteLine(message);
        }
    }
}
