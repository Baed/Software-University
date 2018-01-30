using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class StartUp
{
    public static void Main(string[] args)
    {
        var math = new MathOperations();
        int result1 = math.Add(2, 3);
        double result2 = math.Add(2.2, 3.3, 5.5);
        decimal result3 = math.Add(2.2m, 3.3m, 4.4m);

        Console.WriteLine(result1);
        Console.WriteLine(result2);
        Console.WriteLine(result3);
    }
}
