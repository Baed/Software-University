using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IObservable
{
    void Register(IObserver observer);

    void NotifyObservers();
}

