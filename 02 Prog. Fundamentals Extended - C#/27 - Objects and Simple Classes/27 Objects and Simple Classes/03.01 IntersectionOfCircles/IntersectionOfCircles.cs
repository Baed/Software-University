using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._01_IntersectionOfCircles
{
    class IntersectionOfCircles
    {
        static void Main(string[] args)
        {

            Circle firstCirlce = AddCircle();
            Circle secondCirlce = AddCircle();

            bool isIntersect = IsIntersected(firstCirlce, secondCirlce);

            Writer(isIntersect);
        }

        private static void Writer(bool isIntersect)
        {
            Console.WriteLine(isIntersect ? "Yes" : "No");
        }

        private static bool IsIntersected(Circle firstCirlce, Circle secondCirlce)
        {
            bool isIntersected = firstCirlce.Center.DistaneBetweenCircles(secondCirlce.Center)
                                 <= firstCirlce. Radius + secondCirlce.Radius;

            return isIntersected;
        }

        private static Circle AddCircle()
        {
            int[] input = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Point center = new Point(input[0], input[1]);
            Circle circle = new Circle(center, input[2]);

            return circle;
        }
    }

    public class Circle
    {
        public Circle(Point center, double radius)
        {
            this.Center = center;
            this.Radius = radius;
        }

        public Point Center { get; set; }

        public double Radius { get; set; }
    }

    public class Point
    {
        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public double X { get; set; }

        public double Y { get; set; }

        public double DistaneBetweenCircles(Point center)
        {
            double deltaX = Math.Abs(X - center.X);

            double deltaY = Math.Abs(Y - center.Y);

            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }
    }

}
