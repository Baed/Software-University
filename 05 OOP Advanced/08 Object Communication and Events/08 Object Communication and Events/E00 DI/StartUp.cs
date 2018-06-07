using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

public class StartUp
{
    public static void Main(string[] args)
    {
        // PrimitiveCalculator calc = new PrimitiveCalculator(new AdditionStrategy()); 
        PrimitiveCalculator calc = new PrimitiveCalculator();

        string[] input = Console.ReadLine().Split(' ');
        while (input[0] != "End")
        {
            if (input[0] == "mode")
            {
                calc.changeStrategy(char.Parse(input[1]));
            }
            else
            {
                Console.WriteLine(calc.performCalculation(int.Parse(input[0]), int.Parse(input[1])));
            }

            input = Console.ReadLine().Split(' ');
        }
    }
}

