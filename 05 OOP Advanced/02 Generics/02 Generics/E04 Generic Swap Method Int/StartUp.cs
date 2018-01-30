namespace E04_Generic_Swap_Method_Int
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            IList<Box<double>> listOfBox = new List<Box<double>>();

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = double.Parse(Console.ReadLine());
                var box = new Box<double>(input);

                listOfBox.Add(box);
            }

            var indexes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            SwapOfElements<double>(listOfBox, indexes[0], indexes[1]);

            foreach (var box in listOfBox)
            {
                Console.WriteLine(box.ToString());
            }
        }
        // we use a generic metod 
        private static void SwapOfElements<T>(IList<Box<T>> listOfBox, int index1, int index2)
        {
            Box<T> tempElement = listOfBox[index1];

            listOfBox[index1] = listOfBox[index2];

            listOfBox[index2] = tempElement;
        }
    }
}
