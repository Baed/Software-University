using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_School_room
{
    class Program
    {
        static void Main(string[] args)
        { 
            double heightCorridor = 1.0;
            double widthWorkDesk = 1.2;
            double heigthWorkDesk = 0.7;
            int door = 1;   
            int catedre = 2;
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            if (!(3.0 <= h) || !(h <= w ) || !(w <= 100.0))
            {
                return;
            }

            var row = Math.Floor(w / widthWorkDesk);
            var column = Math.Floor((h - heightCorridor) / heigthWorkDesk);
            var WorkPlace = Math.Truncate(column * row) - door - catedre;

            Console.WriteLine(WorkPlace);



        }
    }
}
