using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Cat : Animal
{
    public string Meow<T>(T element)
    {
        return element.ToString();
    }

    public override string ToString()
    {
        return "I'm a Cat";
    }
}
