using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Rabbit : IAnimal, IMammal
{
    public string Name { get; private set; }

    public int Age { get; private set; }

    public bool HaveABaby()
    {
        throw new NotImplementedException();
    }

    public void IAmMammal()
    {
        throw new NotImplementedException();
    }

    public string MakeNois()
    {
        throw new NotImplementedException();
    }
}

