public class Rectangle : Shape
{
    private double height;
    private double width;

    public Rectangle(double height, double width)
    {
        this.Height = height;
        this.Width = width;
    }

    public double Width
    {
        get { return this.width; }
        set
        {
            // because class Validator is STATIC , canot build
            // var val = new Validator();
            // val.IsValidateSizes(value);
            this.width = value;
        }
    }

    public double Height
    {
        get { return this.height; }
        set
        {
            Validator.IsValidateSizes(value);
            this.height = value;
        }
    }

    public sealed override double CalculateArea()
    {
        return this.Height * this.Width;
    }

    public sealed override double CalculatePerimeter()
    {
        return this.Height * 2 + this.Width * 2;
    }

    public override string Draw()
    {
        return base.Draw() + $"{this.GetType().Name}";
    }

    public static void DoSomething()
    {
        System.Console.WriteLine($"Do something in class Rectangle");
    }
}

