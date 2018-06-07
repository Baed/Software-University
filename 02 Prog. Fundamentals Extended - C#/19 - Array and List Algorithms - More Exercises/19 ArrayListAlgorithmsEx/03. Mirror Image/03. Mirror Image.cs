using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Mirror_Image
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] elements = Console.ReadLine().Split(' ').ToArray();

            while (true)
            {
                string position = Console.ReadLine();
                if (position == "Print")
                {
                    break;
                }

                int index = int.Parse(position);

                for (int i = 0; i < index / 2; i++)
                {
                    string temp = elements[i];
                    elements[i] = elements[index - 1 - i];
                    elements[index - 1 - i] = temp;
                }
                Array.Reverse(elements);

                for (int i = 0; i < (elements.Length - 1 - index) / 2; i++)
                {
                    string temp = elements[i];
                    elements[i] = elements[elements.Length - index - 2 - i];
                    elements[elements.Length - index - 2 - i] = temp;
                }

                Array.Reverse(elements);
            }
            Console.WriteLine(string.Join(" ", elements));
        }
    }
}
