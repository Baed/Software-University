using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.CountCapitalLettersArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] textInput = Console.ReadLine().Split().ToArray();
            int cnt = 0;
            for (int i = 0; i < textInput.Length; i++)
            {
                string currentText = textInput[i];
                if (currentText.Length == 1)
                {
                    char currentLetter = currentText[0];
                    if (char.IsUpper(currentLetter))
                    {
                        cnt++;
                    }
                }
            }
            Console.WriteLine(cnt);
        }
    }
}
