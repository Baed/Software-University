namespace E04_Speed_Racing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Car
    {
        public Car(string model, double fuel, double consumption)
        {
            this.Model = model;
            this.Fuel = fuel;
            this.Consumption = consumption;
            this.Distance = 0;
        }

        public string Model { get; set; }

        public double Fuel { get; set; }

        public double Consumption { get; set; }

        public double Distance { get; set; }

        public bool Move(double distance)
        {
            double fuelNeeded = distance * this.Consumption;

            if (this.Fuel < fuelNeeded)
            {
                return false;
            }

            this.Fuel -= fuelNeeded;
            this.Distance += distance;

            return true;
        }
    }
}
