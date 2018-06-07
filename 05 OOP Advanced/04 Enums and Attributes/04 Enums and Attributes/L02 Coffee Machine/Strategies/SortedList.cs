using System.Collections.Generic;

public class SortedList
{
    private IList<object> list;

    public void Sort(ISortStrategy strategy)
    {
        strategy.Sort(this.list);
    }
}