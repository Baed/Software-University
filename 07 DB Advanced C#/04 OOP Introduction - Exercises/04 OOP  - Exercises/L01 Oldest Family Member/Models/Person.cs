using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L01_Oldest_Family_Member
{
    public class Person
    {
        private string _name;
        private int _age;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name
        {
            get => _name;

            protected set
            {
                _name = value;
            }
        }

        public int Age
        {
            get => _age;

            protected set
            {
                _age = value;
            }
        }

        public override string ToString()
        {
            return $"{this.Name} {this.Age}";
        }
    }
}
