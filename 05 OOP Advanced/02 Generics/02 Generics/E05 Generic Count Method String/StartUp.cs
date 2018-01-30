
namespace E05_Generic_Count_Method_String
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StartUp // and E06
    {
        public static void Main(string[] args)
        {
            List<Box<double>> listOfBox = new List<Box<double>>();

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                Box<double> box = new Box<double>(double.Parse(input));

                listOfBox.Add(box);
            }

            var element = double.Parse(Console.ReadLine());

            var result = GetGreaterElementCount(listOfBox, element);

            Console.WriteLine(result.ToString());

        }

        private static double GetGreaterElementCount<T>(List<Box<T>> list, T element)
            where T : IComparable<T>
        {
            int result = list.Count(b => b.Value.CompareTo(element) > 0);

            return result;
        }
    }
}
