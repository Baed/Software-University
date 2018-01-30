public class TestStartUp
{
    public static void TestMain()
    {
        SortedList list1 = new SortedList();
        SortedList list2 = new SortedList();
        SortedList list3 = new SortedList();
        SortedList list4 = new SortedList();

        list1.Sort(new MergeSort());
        list2.Sort(new QuickSort());
        list3.Sort(new SelectedSort());
    }
}