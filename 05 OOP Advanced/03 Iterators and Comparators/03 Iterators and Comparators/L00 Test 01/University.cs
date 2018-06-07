using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L00_Test_01
{
    public class University : IEnumerable<Student>
    {
        private readonly List<Student> students;

        public University()
        {
            this.students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            this.students.Add(student);
        }

        public IEnumerator<Student> GetEnumerator()
        {

            // return this.students.GetEnumerator();
            // return new CustomIterator(students); 
            // using this row for custom Iterator from nasted class

            for (int i = 0; i < this.students.Count; i += 2)
            {
                yield return this.students[i]; // works same like a CustomIterator
            }

        }

        IEnumerator IEnumerable.GetEnumerator() // legasy metods for older .Net platform
        {
            return this.GetEnumerator();
        }

        // Nasted class for using a Custom Iterator
        private class CustomIterator : IEnumerator<Student> 
        {
            private int currentIndex;
            private readonly IList<Student> students;

            public CustomIterator(IList<Student> students)
            {
                this.Reset(); // stay on first position in List 
                this.students = students;
            }

            public Student Current { get { return this.students[currentIndex]; } }

            object IEnumerator.Current => this.Current;

            public void Dispose()
            {               
            }

            public bool MoveNext()
            {
                return (currentIndex += 2) < this.students.Count; 
            }

            public void Reset()
            {
                this.currentIndex = -2; // 
            }
        }
    }
}
