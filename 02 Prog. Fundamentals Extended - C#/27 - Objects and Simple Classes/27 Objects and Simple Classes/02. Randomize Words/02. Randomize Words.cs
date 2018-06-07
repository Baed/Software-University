using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');
            Random rnd = new Random();
            for (int i = 0; i < words.Length; i++)
            {
                int index = rnd.Next(0, words.Length);

                string temp = words[i];
                words[i] = words[index];
                words[index] = temp;
            }

            //Console.WriteLine(string.Join("\n", words));

            words.ToList().ForEach(Console.WriteLine);
        }
    }
}
