using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IBox<T>
{
    void Add(T element);

    T Remove();

    int Count { get; }
}

