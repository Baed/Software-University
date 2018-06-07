using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Child
{
    // Child(foodCost, toy1Cost, toy2Cost…, toy3NCost) Child(foodCost, toy1Cost, toy2Cost…, toy3NCost) 

    private decimal[] consumption;

    public Child(decimal[] consumption)
    {
        this.consumption = consumption;
    }

    public decimal GetTotalConsumption()
    {
        return this.consumption.Sum();
    } 
}
