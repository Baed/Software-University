using System.Collections.Generic;

public interface ISortStrategy // Strategy Pattern
{
    void Sort(IList<object> list);
}