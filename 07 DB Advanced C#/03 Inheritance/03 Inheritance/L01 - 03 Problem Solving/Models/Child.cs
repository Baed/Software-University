using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L01___03_Problem_Solving.Models
{
    public class Child : Person
    {
        public Child(string name, int age)
            : base(name, age)
        {
            this.Age = age;
        }

        public override string Name
        {
            get => base.Name;
            set => base.Name = value;

        }

        public override int Age
        {
            get => base.Age;

            set
            {
                if (value > 15)
                {
                    throw new ArgumentException("Children should not be able to have age more than 15.");
                }

                base.Age = value;
            }
        }
    }
}
