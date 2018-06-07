using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E03_Raw_Data.Models.Entity
{
    public class Tire
    {
        private double _pressure;
        private int _age;


        public Tire(double pressure, int age)
        {
            this.Pressure = pressure;
            this.Age = age;
        }

        public double Pressure
        {
            get => _pressure;
            set => _pressure = value;
        }

        public int Age
        {
            get => _age;
            set => _age = value;
        }
    }
}
