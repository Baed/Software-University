
namespace E09_Collection_Hierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Collection<T>
    {
        private readonly IList<T> list;

        protected Collection()
        {
            this.list = new List<T>();
        }

        public IList<T> List { get => this.list; }
    }
}
