namespace E01_Vehicles
{
    using System;

    public class Bus : Vehicle
    {
        private const double AcConsumpsionMod = 1.4;

        public Bus(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity)
            : base(fuelQuantity, fuelConsumptionPerKm, tankCapacity)
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

        protected override bool Drive(double distance, bool isAcOn)
        {
            double requiredFuel = 0;

            if (isAcOn)
            {
                requiredFuel = distance * (this.FuelConsumptionPerKm + AcConsumpsionMod);
            }
            else
            {
                requiredFuel = distance * this.FuelConsumptionPerKm;
            }

            if (requiredFuel <= this.FuelQuantity)
            {
                this.FuelQuantity -= requiredFuel;
                return true;
            }

            return false;
        }
    }
}
