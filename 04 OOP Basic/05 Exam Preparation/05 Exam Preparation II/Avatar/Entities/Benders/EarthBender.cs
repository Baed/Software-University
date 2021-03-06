﻿public class EarthBender : Bender
{
    public EarthBender(string name, int power, double groundSaturation)
        : base(name, power)
    {
        this.GroundSaturation = groundSaturation;
    }

    public double GroundSaturation  { get; private set; }

    public override double GetTotalPower()
    {
        return this.GroundSaturation * base.Power;
    }

    public override string ToString()
    {
        //var name = this.GetType().Name;
        //var index = name.IndexOf("Saturation");
        //name.Insert(index, " ");

        // "{basename}: {benderName}, Power: {power}, Ground Saturation: {aerialIntegrity}"
        return $"{base.ToString()}Ground Saturation: {this.GroundSaturation:f2}";
    }
}

