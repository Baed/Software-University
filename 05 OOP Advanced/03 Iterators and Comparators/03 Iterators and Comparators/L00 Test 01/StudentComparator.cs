using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L00_Test_01
{
    public class StudentComparator : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            if (x.Age != y.Age)
            {
                return x.Age - y.Age;
            }

            if (x.Name != y.Name)
            {
                return x.Name.CompareTo(y.Name);
            }

            return 0;
        }
    }
}
