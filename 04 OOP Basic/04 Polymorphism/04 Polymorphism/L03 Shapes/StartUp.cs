using System;

public class StartUp
{
    public static void Main(string[] args)
    {
        Shape rectagle = new Rectangle(3.0, 4.0);
        // When we have public SEALED class Rectangle
        // We cannot build ---> Shape rectagle = new Rectangle(3.0, 4.0);

        Shape circle = new Circle(4.0);

        Rectangle square = new Square(3.0);

        Console.WriteLine(rectagle.Draw());
        Console.WriteLine(rectagle.CalculatePerimeter());
        Console.WriteLine(circle.CalculateArea());

        Console.WriteLine(circle.Draw());
        Console.WriteLine(rectagle.CalculatePerimeter());
        Console.WriteLine(circle.CalculatePerimeter());

        Console.WriteLine(square.Draw());
        Console.WriteLine(square.CalculateArea());
        Console.WriteLine(square.CalculatePerimeter());

        Rectangle.DoSomething();
    }
}
