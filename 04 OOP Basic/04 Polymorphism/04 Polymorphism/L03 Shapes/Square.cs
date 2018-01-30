using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Square : Rectangle
{
    // When we have public SEALED class Rectangle 
    public Square(double side)
        : base(side, side)
    {

    }
    // because the metods
    // double CalculateArea() and CalculatePerimeter()
    // are public SEALED override
    // in class Square 
    // we cannot create override metods 

    public override string Draw()
    {
        return base.Draw() + $"{this.GetType().Name}";
    }

}


