namespace E01_Vehicles
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Vehicle
    {
        public Vehicle(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity)
        {
            this.TankCapacity = tankCapacity;
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumptionPerKm = fuelConsumptionPerKm;
            
        }
        // Automatic property ,because we dont have a validation --> set { if(){ } }

        protected virtual double FuelQuantity { get; set; }

        protected double FuelConsumptionPerKm { get; set; }

        protected virtual double TankCapacity { get; set; }

        //fuel requiredment
        protected virtual bool Drive(double distance, bool isAcOn)
        {
            var fuelRequired = distance * this.FuelConsumptionPerKm;

            if (fuelRequired <= this.FuelQuantity)
            {
                this.FuelQuantity -= fuelRequired;
                return true;
            }

            return false;
        }

        public string TryTravelDistance(double distance, bool isAcOn)
        {
            if (this.Drive(distance, isAcOn)) // with pasenger
            {
                return $"{this.GetType().Name} travelled {distance} km"; // Car or Truck
            }

            return $"{this.GetType().Name} needs refueling";
        }

        public string TryTravelDistance(double distance)
        {
            return this.TryTravelDistance(distance, true); // without pasenger
        }

        public virtual void Refuel(double fuelAmount) // => FuelQuantity += fuelAmount;  (Lambda expresion)
        {
            if (fuelAmount <= 0)
            {
                throw new ArgumentException($"Fuel must be a positive number");
            }
            this.FuelQuantity += fuelAmount;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
        }
    }
}
