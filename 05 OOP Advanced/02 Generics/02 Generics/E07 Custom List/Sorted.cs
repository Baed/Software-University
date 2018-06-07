
namespace E07_Custom_List
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Sorted
    {
        public static CustomList<T> Sort<T>(CustomList<T> customList)
            where T : IComparable<T>
        {
            var sortedList = customList
                .Elements
                .OrderBy(e => e)
                .ToList();          

            return new CustomList<T>(sortedList);
        }
    }
}
