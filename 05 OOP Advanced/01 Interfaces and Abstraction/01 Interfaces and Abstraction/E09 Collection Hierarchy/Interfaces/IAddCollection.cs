
namespace E09_Collection_Hierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IAddCollection<T>
    {
        int Add(T element);
    }
}
