using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Rectangle_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstRectArgs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secondRectArgs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Rectangle FirstRectangle = new Rectangle
            {
                Left = firstRectArgs[0],
                Top = firstRectArgs[1],
                Width = firstRectArgs[2],
                Height = firstRectArgs[3],
            };
            Rectangle SecondRectangle = new Rectangle
            {
                Left = secondRectArgs[0],
                Top = secondRectArgs[1],
                Width = secondRectArgs[2],
                Height = secondRectArgs[3],
            };
            if (FirstRectangle.IsInside(SecondRectangle))
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }
        }
    }
    class Rectangle
    {
        public int Top { get; set; }
        public int Left { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public int Bottom
        {
            get
            {
                return Top + Height;
            }
        }
        public int Right
        {
            get
            {
                return Left + Width;
            }
        }
        int CalcArea()
        {
            return Width * Height;
        }
        public bool IsInside(Rectangle secondRectangle)
        {
            return Top >= secondRectangle.Top 
                && Left >= secondRectangle.Left 
                && Bottom <= secondRectangle.Bottom 
                && Right <= secondRectangle.Right;
        }
    }
}
