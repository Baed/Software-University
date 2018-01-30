using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_School_room_second_way
{
    class Program
    {
        static void Main(string[] args)
        {
            double corridorWidth = 1.0f;
            double deskHeight = 1.2f;
            double deskWidth = 0.7f;
            double desksPerRow;
            double desksPerColumn;


            Console.Write("Give height ");
            double height = double.Parse(Console.ReadLine());

            Console.Write("Give width ");
            double width = double.Parse(Console.ReadLine());


            if (!(3.0f <= height) || !(height >= width) || !(width <= 100.0f))
            {
                return;
            }

            desksPerRow = System.Math.Floor((width - corridorWidth) / deskWidth);
            desksPerColumn = System.Math.Floor(height / deskHeight);
            Console.WriteLine(desksPerRow * desksPerColumn - 3);
        }
    }
}
