using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_03_09_17_task_3_photo_pictures
{
    class Program
    {
        static void Main(string[] args)
        {
            int pictures = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string order = Console.ReadLine();

            double price = 0.0;

            switch (type)
            {
                case "9X13":
                    price = 0.16 * pictures;
                    if (pictures >= 50)
                    {
                        price *= 0.95; // price -= price * 0.05;
                    }
                    break;
                case "10X15":
                    price = 0.16 * pictures;
                    if (pictures >= 80)
                    {
                        price *= 0.97; // price -= price * 0.03;
                    }
                    break;
                case "13X18":
                    price = 0.38 * pictures;
                    if (pictures > 100)
                    {
                        price *= 0.95;
                    }
                    else if (pictures >= 50)
                    {
                        price *= 0.97;
                    }
                    break;
                case "20X30":
                    price = 2.90 * pictures;
                    if (pictures > 50)
                    {
                        price *= 0.91;
                    }
                    else if (pictures >= 10)
                    {
                        price *= 0.93;
                    }
                    break;
            }

            if (order == "online")
            {
                price *= 0.98;
            }

            Console.WriteLine("{0:f2}BGN", price);
        }
    }
}
