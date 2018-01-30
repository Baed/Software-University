
namespace E07_Custom_List
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CustomList<T> : ICustomList<T>, IEnumerable<T>
        where T : IComparable<T>
    {
        private readonly IList<T> list;

        public CustomList() : this(Enumerable.Empty<T>()) // ctor
        {
        }

        public CustomList(IEnumerable<T> collection) // ctor
            
        {
            this.list = new List<T>(collection);
        }

        public IList<T> Elements // prop
        {
            get { return this.list; }
        } 

        public void Add(T element)
        {
            this.list.Add(element);
        }

        public bool Contains(T element)
        {
            return this.list.Contains(element);
        }

        public int CountGreaterThan(T element)
        {
            return this.list.Count(e => e.CompareTo(element) > 0);
        }

        public T Max()
        {
            return this.list.Max();
        }

        public T Min()
        {
            return this.list.Min();
        }

        public T Remove(int index)
        {
            T temp = this.list[index];
            this.list.RemoveAt(index);

            return temp;
        }

        public void Swap(int index1, int index2)
        {
            T swappedElement = this.list[index1];
            this.list[index1] = this.list[index2];
            this.list[index2] = swappedElement;
        }

        public void Print()
        {
            foreach (var element in this.list)
            {
                Console.WriteLine(element);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this.list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
