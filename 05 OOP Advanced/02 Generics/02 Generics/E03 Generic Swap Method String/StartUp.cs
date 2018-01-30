
namespace E03_Generic_Swap_Method_String
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
            List<Box<string>> listOfBox = new List<Box<string>>();

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                var box = new Box<string>(input);

                listOfBox.Add(box);
            }

            var indexes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            SwapOfElements<string>(listOfBox, indexes[0], indexes[1]);

            foreach (var box in listOfBox)
            {
                Console.WriteLine(box.ToString());
            }
        }
        // we use a generic metod 
        private static void SwapOfElements<T>(List<Box<T>> listOfBox, int index1, int index2)
        {
            Box<T> tempElement = listOfBox[index1];

            listOfBox[index1] = listOfBox[index2];

            listOfBox[index2] = tempElement;
        }
    }
}
