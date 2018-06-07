using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Increasing_Crisis
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            int n = int.Parse(Console.ReadLine());

            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            n--;
            input.Sort();
            numbers = input;

            while (n > 0)
            {
                input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

                for (int i = numbers.Count - 1; i >= 0; i--)
                {
                    if (numbers[i] <= input[0])
                    {
                        i++;
                        numbers.Insert(i, input[0]);
                        for (int k = 1; k < input.Count; k++)
                        {

                            if (input[k] >= input[k - 1])
                            {
                                i++;
                                numbers.Insert(i, input[k]);

                                if (i != numbers.Count - 1 && numbers[i] > numbers[i + 1])
                                {
                                    for (int p = i + 1; p < numbers.Count; p++)
                                    {
                                        numbers.RemoveAt(p);
                                        p--;
                                    }
                                    break;
                                }

                            }
                            else
                            {
                                for (int p = i + 1; p < numbers.Count; p++)
                                {
                                    numbers.RemoveAt(p);
                                    p--;
                                }
                                break;
                            }
                        }
                        break;
                    }
                }

                n--;

            }

            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}
