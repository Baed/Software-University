using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public static class Validator// STATIC class --> all is STATIC 
{
    public static double IsValidateSizes(double size)
    {
        if (size < 2 || 20 < size)
        {
            throw new ArgumentException($"Ivalid size");
        }
        else
        {
            return size;
        }
    }

    public static object ValidateForNull(object obj)
    {
        if (obj == null)
        {
            throw new NullReferenceException($"Cannot use NULL name to object");
        }
        else
        {
            return obj;
        }
    }
}

