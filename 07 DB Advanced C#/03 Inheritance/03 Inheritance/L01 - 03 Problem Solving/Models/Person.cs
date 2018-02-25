using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L01___03_Problem_Solving.Models
{
    public class Person
    {
        private string _name;
        private int _age;

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public virtual string Name
        {
            get => this._name;

            set
            {
                if (value.Length < 3)
                {
                    throw  new ArgumentException("People’s names should be at least 3 symbols long");
                }
                this._name = value;
            }
        }

        public virtual int Age
        {
            get => this._age;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age must be positive!");
                }

                this._age = value;
            }
        }

        public override string ToString()
        {
            return $"Name: {this.Name}, Age: {this.Age}";
        }
    }
}
