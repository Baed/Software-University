using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E03_Raw_Data.Models.Entity;

namespace E03_Raw_Data.Models
{
    public class Car
    {
        private string _model;
        private Cargo _cargo;
        private Engine _engine;
        private IList<Tire> _tires;

        public Car(string model, Engine engine, Cargo cargo)
        {
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;
            this._tires = new List<Tire>();
        }

        public string Model
        {
            get => _model;

            set
            {
                _model = value;
            }
        }

        public Engine Engine
        {
            get => _engine;

            set
            {
                _engine = value;
            }
        }

        public Cargo Cargo
        {
            get => _cargo;

            set
            {
                _cargo = value;
            }
        }

        public IList<Tire> Tires
        {
            get => _tires;

            protected set
            {
                _tires = value;
            }
        }

        public void AddTires(Tire tire)
        {
            this.Tires.Add(tire);
        }
    }
}
