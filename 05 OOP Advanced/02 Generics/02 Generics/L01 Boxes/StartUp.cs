using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class StartUp
{
    public static void Main(string[] args)
    {
        Box<string> boxOfString = new Box<string>();
        Box<int> boxOfInt = new Box<int>();
        // Console.WriteLine(boxOfInt.Remove()); output 0 --> return default(T) in metod

        Box<string> box1 = new Box<string>();
        box1.Add("1");
        box1.Add("2");
        box1.Add("3");
        Console.WriteLine(box1.Remove()); // output: 3

        Box<int> box2 = new Box<int>();
        box2.Add(4);
        box2.Add(5);
        Console.WriteLine(box2.Remove()); // output: 5

        Box<Cat> box = new Box<Cat>();

        box.Add(new Cat());
        box.Add(new Cat());
        box.Add(new Cat());
        box.Add(new Cat());
        box.Add(new Cat());

        Console.WriteLine(box.Remove()); // output: I'm a Cat
        Console.WriteLine(box.Count); // output: 4

        Box<Animal> box3 = new Box<Animal>();
        box3.Add(new Cat());

        Console.WriteLine(box.Remove());
        Console.WriteLine(box.Count);

        Cat cat = new Cat();

        Console.WriteLine(cat.Meow(20));
        Console.WriteLine(cat.Meow("Hey!"));

    }
}

