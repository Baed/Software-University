using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class StartUp
{
    public static void Main(string[] args)
    {
        IAnimal cat = new Cat("Pesho", 4);

        IAnimal dog = new Dog("Gosho", 5);

        Print(cat);
        Print(dog);
    }

    private static void Print(IAnimal animal)
    {
        Console.WriteLine(animal.MakeNois());
    }
}

