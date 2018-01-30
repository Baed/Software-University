using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_test
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n - 2; i++)
            {
                char wingMaterial = i % 2 == 0 ? '*' : '-';
                string wings = new string(wingMaterial, n - 2);
                string line = wings + "\\ /" + wings;
            }
            Console.WriteLine("{0}@{0}", new string(' ', n - 1));
    
            for (int i = 0; i < n - 2; i++)
            {
                char wingMaterial = i % 2 == 0 ? '*' : '-';
                string wings = new string(wingMaterial, n - 2);
                string line = wings + "/ \\" + wings;
                Console.WriteLine(line);
            }
    }
}
