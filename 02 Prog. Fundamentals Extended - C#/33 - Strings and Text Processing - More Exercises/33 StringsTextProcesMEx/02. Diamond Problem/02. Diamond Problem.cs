using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Diamond_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool isFound = false;
            int leftiIndex = -1;
            int rightIndex = -1;

            while ((leftiIndex = input.IndexOf('<', leftiIndex + 1)) > -1 &&
                (rightIndex = input.IndexOf('>', leftiIndex + 1)) > -1)
            {
                string diamondContent = input.Substring(leftiIndex + 1, rightIndex - leftiIndex - 1);

                int carats = FindCarats(diamondContent);
                Console.WriteLine($"Found {carats} carat diamond");
                isFound = true;
            }
            if (!isFound)
            {
                Console.WriteLine("Better luck next time");
            }
        }

        private static int FindCarats(string diamondContent)
        {
            int carats = 0;
            foreach (char item in diamondContent)
            {
                if (char.IsDigit(item))
                {
                    carats += int.Parse(item.ToString());
                }
            }
            return carats;
        }
    }
}
