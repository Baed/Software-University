using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Thea_Photograph
{
    class Program
    {
        static void Main(string[] args)
        {
            long picsCount = long.Parse(Console.ReadLine());

            long filterTime = long.Parse(Console.ReadLine());

            long filterFactor = long.Parse(Console.ReadLine());

            long uploadedTime = long.Parse(Console.ReadLine());

            var usefulPics = (long)(Math.Ceiling(picsCount * filterFactor / 100.0));

            long totalPicture = picsCount * filterTime;

            long uploadedPics = usefulPics * uploadedTime;

            long result = totalPicture + uploadedPics;

            TimeSpan timeSpan = TimeSpan.FromSeconds(result);

            Console.WriteLine(timeSpan.ToString(@"d\:hh\:mm\:ss"));
        }
    }
}
