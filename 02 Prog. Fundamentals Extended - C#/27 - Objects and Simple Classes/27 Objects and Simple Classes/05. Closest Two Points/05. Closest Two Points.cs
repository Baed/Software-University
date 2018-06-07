using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Closest_Two_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Point> points = new List<Point>();

            for (int i = 0; i < n; i++)
            {
                Point currentPoint = Point.ParsePoint(Console.ReadLine()); // metod parse

                points.Add(currentPoint);
            }

            double minDistance = double.MaxValue;
            Point[] bestPoints = new Point[2];

            for (int prevPoint = 0; prevPoint < points.Count; prevPoint++) // i = 1;
            {
                for (int curPoint = prevPoint + 1; curPoint < points.Count; curPoint++) // i = 1;
                {
                    double distance = CalcDistance(points[prevPoint], points[curPoint]);

                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        bestPoints[0] = points[prevPoint];
                        bestPoints[1] = points[curPoint];
                    }
                }
            }

            Console.WriteLine($"{minDistance:f3}");
            Console.WriteLine(bestPoints[0]); // metod format
            Console.WriteLine(bestPoints[1]); // metod format

        }
        private static double CalcDistance(Point firstPoint, Point secondPoint)
        {
            double sideA = Math.Pow((firstPoint.X - secondPoint.X), 2);
            double sideB = Math.Pow((firstPoint.Y - secondPoint.Y), 2);

            return Math.Sqrt(sideA + sideB);
        }
    }
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int xCoord, int yCoord)
        {
            X = xCoord;
            Y = yCoord;
        }
        public static Point ParsePoint(string input)
        {
            int[] data = input.Split(' ').Select(int.Parse).ToArray();
            return new Point(data[0], data[1]);
        }
        public override String ToString()
        {
            return String.Format($"({X}, {Y})");
        }
    }
}
