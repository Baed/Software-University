using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Sign_Stop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var dot_width = n;
            var dashes_width = n - 1;
            
            Console.WriteLine("{0}{1}{0}", new string('.', n + 1), new string('_', 2 * n + 1)); // first row

            for (int i = 0; i < n ; i++) // first row < ==UPPER body== < Stop row
            {
                dot_width--;
                dashes_width++;
                Console.WriteLine("{0}//{1}\\\\{0}", new string('.', dot_width + 1), new string('_', 2 * dashes_width - 1));
            }

            Console.WriteLine("//{0}STOP!{0}\\\\", new string('_', dashes_width - 2)); // Stop row

            for (int i = 0; i < n; i++) // Stop row < ==LOWER body== 
            {
                dot_width++; 
                dashes_width--;
                Console.WriteLine("{0}\\\\{1}//{0}", new string('.', dot_width - 1), new string('_', 2 * dashes_width + 3));
            }



        }
    }
}
