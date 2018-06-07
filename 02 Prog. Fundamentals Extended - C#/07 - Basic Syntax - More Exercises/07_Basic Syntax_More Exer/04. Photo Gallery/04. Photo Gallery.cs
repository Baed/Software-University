using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Photo_Gallery
{
    class Program
    {
        static void Main(string[] args)
        {
            int picName = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            double size = double.Parse(Console.ReadLine());
            int rezWidht = int.Parse(Console.ReadLine());
            int rezHeight = int.Parse(Console.ReadLine());
            var unit = "";
            var sizeType = "";
            Console.WriteLine($"Name: DSC_{picName:D4}.jpg");
            Console.WriteLine($"Date Taken: {day:d2}/{month:d2}/{year:d4} {hour:00}:{minutes:00}");
            if (size >= 1000000.0)
            {
                unit = "MB";
                size = Math.Round((size / 1000000), 2);
            }
            else if (size >= 1000)
            {
                unit = "KB";
                size = Math.Round((size / 1000), 0);
            }
            else
            {
                unit = "B";
                size = Math.Round((size), 0);
            }
            Console.WriteLine($"Size: {size}{unit}");

            if (rezWidht > rezHeight)
            {
                sizeType = "(landscape)";
            }
            else if (rezWidht < rezHeight)
            {
                sizeType = "(portrait)";
            }
            else
            {
                sizeType = "(square)";
            }
            Console.WriteLine($"Resolution: {rezWidht}x{rezHeight} {sizeType}");
        }
    }
}
