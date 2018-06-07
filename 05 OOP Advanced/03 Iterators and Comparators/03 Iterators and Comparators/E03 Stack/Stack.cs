namespace E03_Stack
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Stack<T> : IEnumerable<T>
    {
        private const int initialCapacity = 10; // individual value
        private T[] elements;

        public Stack()
        {
            this.elements = new T[initialCapacity];
        }

        public int Count { get; set; }

        public int Capacity // base value == 0;
        {
            get { return this.elements.Length; }
        }

        public void Push(T element)
        {
            this.elements[this.Count] = element;
            this.Count++;

            if (this.Count == this.Capacity)
            {
                this.Resize();
            }
        }

        public T Pop()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("No elements");
            }

            T tempElement = this.elements[this.Count - 1]; // last index
            this.Count--;
            
            return tempElement;
        }

        private void Resize()
        {
            this.elements = this.elements.Concat(new T[this.Count]).ToArray();
            //Array.Resize(ref this.elements, 2 * this.Count);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.Count - 1; i >= 0; i--)
            {
                yield return this.elements[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
