using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class EvenCalculator : IObserver
{
    public int Number { get; set; }

    public void Notify(int number)
    {
        this.Number = number;
    }
}

