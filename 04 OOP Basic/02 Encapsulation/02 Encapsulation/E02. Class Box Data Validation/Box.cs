using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Box
{
    private double length;
    private double width;
    private double height;

    public Box(double length, double width, double height)
    {
        this.Length = length;
        this.Width = width;
        this.Height = height;
    }

    private double Length
    {
        // private property, dont needed getter
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException($"{nameof(Length)} cannot be zero or negative.");
            }
            this.length = value;
        }
    }
    private double Width
    {
        // private property, dont needed getter
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException($"{nameof(Width)} cannot be zero or negative.");
            }
            this.width = value;
        }
    }
    private double Height
    {
        // private property, dont needed getter
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException($"{nameof(Height)} cannot be zero or negative.");
            }
            this.height = value;
        }
    }
    public double GetSurfaceArea()
    {
        return 2 * this.length * this.width + 2 * this.length * this.height + 2 * this.width * this.height;
    }
    public double GetLateralSurfaceArea()
    {
        return 2 * this.length * this.height + 2 * this.width * this.height;
    }
    public double GetVolume()
    {
        return this.length * this.height * this.width;
    }
}
