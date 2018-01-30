using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class StartUp
{
    public static void Main(string[] args)
    {
        Subject sub = new Subject(8);

        IObserver even = new EvenCalculator();
        IObserver odd = new OddCalculator();

        sub.Register(even);
        sub.Register(odd);

        for (int i = 0; i < 5; i++)
        {
            sub.Number = int.Parse(Console.ReadLine());

            sub.NotifyObservers();

            Console.WriteLine(even.Number);
            Console.WriteLine(odd.Number);
        }
    }
}

