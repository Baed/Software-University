using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Unvalid_num
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            bool invalid = number >= 100 && number <= 200 || number == 0;
            // && - priorited pred ||

            if (!invalid) // ! - tozi znak e otricanie otpechatva rezultata koito e "false"
            {
                Console.WriteLine("invalid");
            }



        }
    }
}
