using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05___SoftUni_Logo
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}#{0}", new string('.', (12 * n - 5)/2));

            var sharps = 0;
            var dots = 3;
            for (int i = 0; i < 2 * n - 1; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', (12 * n - 5) / 2 - dots), new string('#', 7 + sharps));
                sharps += 6; // purvo vliza 7 i sled tova pribavq + 6;
                dots += 3;
            }

            sharps = 0;
            dots = 0;
            for (int i = 0; i < n - 2; i++) 
            {
                Console.WriteLine("|{0}{1}{2}", new string('.', 2 + dots), new string('#', (12 * n - 5) - 6 - sharps), new string('.', 3 + dots));
                sharps += 6;
                dots += 3;
            }

            
            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine("|{0}{1}{2}", new string('.', 2 + dots), new string('#', n * 6 + 1), new string('.', 3 + dots));
            }

            Console.WriteLine("@{0}{1}{2}", new string('.', 2 + dots), new string('#', n * 6 + 1), new string('.', 3 + dots));

        }
    }
}
