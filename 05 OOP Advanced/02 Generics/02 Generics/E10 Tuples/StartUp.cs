namespace E10_Tuples
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StartUp
    {
        public static void Main()
        {
            var inputTokens = Console.ReadLine().Split(' ');

            var firstElement = inputTokens[0] + " " + inputTokens[1];
            var secondElement = inputTokens[2];

            var tuple = new Tuple<string, string>(firstElement, secondElement);
            Console.WriteLine(tuple);

            var inputTokens1 = Console.ReadLine().Split(' ');

            var firstElement1 = inputTokens1[0];
            var secondElement1 = int.Parse(inputTokens1[1]);

            var tuple1 = new Tuple<string, int>(firstElement1, secondElement1);
            Console.WriteLine(tuple1);

            var inputTokens2 = Console.ReadLine().Split(' ');

            var firstElement2 = int.Parse(inputTokens2[0]);
            var secondElement2 = double.Parse(inputTokens2[1]);

            var tuple2 = new Tuple<int, double>(firstElement2, secondElement2);
            Console.WriteLine(tuple2);
        }
    }
}
