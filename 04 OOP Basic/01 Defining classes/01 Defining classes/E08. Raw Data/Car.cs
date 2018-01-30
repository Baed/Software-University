using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Car
    {
        private string model;
        private Engine engine;
        private Cargo cargo;
        private List<Tire> tires;

        public Car(string model, Engine engine, Cargo cargo, List<Tire> tires)
        {
            this.model = model;
            this.engine = engine;
            this.cargo = cargo;
            this.tires = tires;
        }

        public string Model => this.model;

        public bool IsFragile()
        {
            return this.cargo.Cargotype == "fragile"
                && this.tires.Any(t => t.TirePressure < 1);
        }

        public bool IsFlamable()
        {
            return this.cargo.Cargotype == "flamable"
                && this.engine.EnginePower > 250;
        }
    }

