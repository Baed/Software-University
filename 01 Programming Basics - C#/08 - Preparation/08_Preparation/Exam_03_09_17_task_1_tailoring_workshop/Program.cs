using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_03_09_17_task_1_tailoring_workshop
{
    class Program
    {
        static void Main(string[] args)
        {

            int tableCount = int.Parse(Console.ReadLine());
            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            var area_cover = tableCount * (lenght + 2 * 0.30) * (width + 2 * 0.30);
            var area_box = tableCount * (lenght / 2) * (lenght / 2);
            var dollar_price = area_cover * 7 + area_box * 9;
            var leva_price = dollar_price * 1.85;

            Console.WriteLine($"{dollar_price:f2} USD");
            Console.WriteLine($"{leva_price:f2} BGN");
        }
    }
}
