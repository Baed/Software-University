using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class StartUp
{
    public static void Main(string[] args)
    {
        IReader reader = new ConsoleReader();
        // Lottary lottary = new Lottary();
        Random random = new Random();

        // lottary.Number = random.Next(1, 100); // DI --> with prop: public int Number { get; set; }
        // Console.WriteLine(lottary.CheckForWin());

        // lottary.Number = int.Parse(reader.ReadLine()); // DI --> with prop: public int Number { get; set; }
        // Console.WriteLine(lottary.CheckForWin());

        //Console.WriteLine(lottary.CheckForWin(int.Parse(reader.ReadLine()))); // DI --> with parameters: CheckForWin(int number)

        Lottary lottary1 = new Lottary(int.Parse(reader.ReadLine())); // DI --> with ctor: public Lottary(int number) { this.Number = number; }
        Console.WriteLine(lottary1.CheckForWin());
        Lottary lottary2 = new Lottary(random.Next(1, 100)); // DI --> with ctor: public Lottary(int number) { this.Number = number; }
        Console.WriteLine(lottary2.CheckForWin());

    }
}

