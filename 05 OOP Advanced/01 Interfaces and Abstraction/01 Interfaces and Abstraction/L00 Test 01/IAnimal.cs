using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public interface IAnimal
{
    // interfaces cannot contains constructor and fields

    // only autoproperties and metods();

    string Name { get; } // cannot write in prop a public, protected and virtual 

    int Age { get; }

    string MakeNois(); // the metods is aways abstract, but we do not write it.
}

