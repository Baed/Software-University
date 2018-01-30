using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_non_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 5;
            //number++;  --- dobaavq 1
            //number += 5 --- dobavq 5
            // number = number + 5
            Console.WriteLine(number++); //result = 5 vrushta predi operaciqta
            Console.WriteLine(number); // result = 6 sled operaciqta
            Console.WriteLine(++number); // result = 6 sled operaciqta

            // Ako napishem slednoto 6te izleze taka:
            Console.WriteLine(number++); //result = 5 vrushta predi operaciqta
            Console.WriteLine(++number); // result = 7 (5+1+1=7)sled operaciqta
            Console.WriteLine(number++); // result = 7 predi operaciata

        }


    }
}
