
namespace E09_Collection_Hierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MyList<T> : Collection<T>, IMyList<T>
    {
        public int Used { get => this.List.Count; }

        public int Add(T element)
        {
            this.List.Insert(0, element);
            return 0;
        }

        public T Remove()
        {
            T temp = this.List[0];
            this.List.RemoveAt(0);

            return temp;
        }
    }
}
