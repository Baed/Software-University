using System;

public class Rectangle : IDrawable
{
    private int width;
    private int height;

    public Rectangle(int width, int height)
    {
        this.Width = width;
        this.Height = height;
        this.Height = height;
        this.Width = width;
    }

    public int Height
    {
        get { return this.height; }
        private set { this.height = value; }
    }

    public int Width
    {
        get { return this.width; }
        private set { this.width = value; }
    }

    public void Draw() // IDrawable metod
    {
        DrawLine(this.Width, '*', '*');

        for (int i = 1; i < this.Height - 1; ++i)
        {
            DrawLine(this.Width, '*', ' ');
        }

        DrawLine(this.Width, '*', '*');
    }

    public void DrawLine(int width, char end, char mid) // IDrawable metod
    {
        Console.Write(end);

        for (int i = 1; i < width - 1; ++i)
        {
            Console.Write(mid);
        }

        Console.WriteLine(end);
    }
}

