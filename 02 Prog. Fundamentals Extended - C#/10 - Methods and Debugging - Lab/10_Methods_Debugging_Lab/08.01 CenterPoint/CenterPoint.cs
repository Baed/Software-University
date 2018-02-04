using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._01_CenterPoint
{
    class CenterPoint
    {
        static void Main()
        {
            double[] coordinate = Reader();
            List<double> result = ExecuteProgram(coordinate);
            Writer(result);

        }

        private static void Writer(List<double> result)
        {
            Console.Write("(");
            Console.Write(String.Join(", ", result));
            Console.WriteLine(")");
        }

        private static List<double> ExecuteProgram(double[] coordinate)
        {
            double dist1 = CalcDistance(coordinate[0], coordinate[1]);
            double dist2 = CalcDistance(coordinate[2], coordinate[3]);

            var list = new List<double>();

            if (dist1 >= dist2)
            {
                list.Add(coordinate[2]);
                list.Add(coordinate[3]);
            }
            else
            {
                list.Add(coordinate[0]);
                list.Add(coordinate[1]);
            }

            return list;
        }

        public static double CalcDistance(double x, double y)
        {
            double distance = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            return distance;
        }

        private static double[] Reader()
        {
            double[] coordinate = new double[4];

            for (int i = 0; i < coordinate.Length; i++)
            {
                coordinate[i] = double.Parse(Console.ReadLine());
            }

            return coordinate;
        }
    }
}
