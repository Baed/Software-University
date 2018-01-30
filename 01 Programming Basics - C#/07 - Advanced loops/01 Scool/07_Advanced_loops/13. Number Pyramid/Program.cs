using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int current_row = 1;
            int current_number = 1;

            while (current_number <= n)
            {
                for (int i = 0; i < current_row; i++)
                {
                    Console.Write("{0} ", current_number);
                    current_number++;
                    if (current_number > n)
                    {
                        break;
                    }
                }
                current_row++;
                Console.WriteLine();
            }
        }
    }
}
