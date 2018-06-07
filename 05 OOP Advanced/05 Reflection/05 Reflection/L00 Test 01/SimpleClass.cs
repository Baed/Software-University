using System;

namespace L00_Test_01
{
    public class SimpleClass : IComparable<int>
    {
        // private int simpleInt;
        private string simpleString;

        protected readonly string anotherSimpleString;
        //private string notPublicStr;

        public SimpleClass()
            : this("Some text")
        {
        }

        public SimpleClass(string someProp)
        {
            this.SomeProp = someProp;
        }

        public string SomeProp
        {
            get => this.simpleString;
            private set => this.simpleString = value;
        }

        public int CompareTo(int other)
        {
            throw new NotImplementedException();
        }
    }
}