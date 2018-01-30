using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IObserver
{
    int Number { get; set; }

    void Notify(int number);
}

