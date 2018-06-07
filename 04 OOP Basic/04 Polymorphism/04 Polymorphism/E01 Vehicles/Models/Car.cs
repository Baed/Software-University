namespace E01_Vehicles
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Car : Vehicle
    {
        private const double AcConsumptionMod = 0.9;

        public Car(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity)
            : base(fuelQuantity, fuelConsumptionPerKm + AcConsumptionMod, tankCapacity) // + AcConsumptionMod = 0.9 
        {

        }

        protected override double FuelQuantity
        {
            set
            {
                if (value > this.TankCapacity) // Where method bool Drive in Vehicle given fuel requiredment
                {
                    throw new ArgumentException($"Cannot fit fuel in tank");
                }

                base.FuelQuantity = value;
            }
        }
    }
}
