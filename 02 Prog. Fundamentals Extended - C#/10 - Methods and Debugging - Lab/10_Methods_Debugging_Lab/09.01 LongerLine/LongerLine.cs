using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._01_CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            double maxDistance = double.MinValue;

            double[] maxArr = new double[4];

            for (int i = 0; i < 2; i++)
            {
                double x1 = double.Parse(Console.ReadLine());
                double y1 = double.Parse(Console.ReadLine());
                double x2 = double.Parse(Console.ReadLine());
                double y2 = double.Parse(Console.ReadLine());

                double currentDistance = CalculateDistance(x1, y1, x2, y2);

                if (currentDistance > maxDistance)
                {
                    maxDistance = currentDistance;
                    maxArr[0] = x1;
                    maxArr[1] = y1;
                    maxArr[2] = x2;
                    maxArr[3] = y2;
                }
            }

            GetTheClosestPoint(maxArr[0], maxArr[1], maxArr[2], maxArr[3]);

        }

        static double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));

            return distance;
        }

        static void GetTheClosestPoint(double x1, double y1, double x2, double y2)
        {
            if (Math.Abs(Math.Pow(x1, 2) + Math.Pow(y1, 2)) <= Math.Abs(Math.Pow(x2, 2) + Math.Pow(y2, 2)))
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
        }
    }
}
