using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Subject : IObservable
{
    private List<IObserver> observers;

    public Subject(int number)
    {
        this.Number = number;
        this.observers = new List<IObserver>();
    }

    public int Number { get; set; }


    public void NotifyObservers()
    {
        foreach (IObserver observer in observers)
        {
            observer.Notify(this.Number);
        }
    }

    public void Register(IObserver observer)
    {
        this.observers.Add(observer);
    }
}

