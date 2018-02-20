using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._01_LettersChangeNumber
{
    class LettersChangeNumber
    {
        static void Main(string[] args)
        {
            decimal sum = 0;
            List<string> input = Console.ReadLine()
                                    .Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                                    .Select(x => x.Trim())
                                    .ToList();

            for (int i = 0; i < input.Count; i++)
            {
                char[] current = input[i].ToCharArray();

                decimal curentSum = 0;

                char first = current[0];
                char last = current[current.Length - 1];

                int firstToNumber = char.ToUpper(first) - 64;
                int secoundToNumber = char.ToUpper(last) - 64;

                string number = string.Empty;
                for (int j = 1; j < current.Length - 1; j++)
                {
                    number += current[j];
                }

                decimal num = decimal.Parse(number);

                if (char.ToUpper(first) == first)
                {
                    curentSum += num / firstToNumber;
                }
                else
                {
                    curentSum += num * firstToNumber;
                }
                if (char.ToUpper(last) == last)
                {
                    curentSum -= secoundToNumber;
                }
                else
                {
                    curentSum += secoundToNumber;
                }
                sum += curentSum;
            }
            Console.WriteLine("{0:f2}", sum);
        }
    }
}
