using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_03_09_17_task_4_cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int pieces_total = width * height;
            int pieces_taken = 0;

            string input = Console.ReadLine();

            while (input != "STOP" && pieces_taken <= pieces_total) //while (input != "STOP")
            {
                int taken = int.Parse(input);
                pieces_taken += taken;
                
                /*
                if (pieces_taken > pieces_total)
                {
                    break;
                }
                */

                input = Console.ReadLine();
            }

            if (pieces_taken > pieces_total)
            {
                Console.WriteLine("No more cake left! You need {0} pieces more.", pieces_taken - pieces_total);
            }
            else
            {
                Console.WriteLine("{0} pieces are left.", pieces_total - pieces_taken);
            }
        }
    }
}
