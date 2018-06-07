using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class AlongYoung : Single
{
    // An alone young person has a room and a laptop. 
    // Room’s electricity cost is: 10.

    private const int NumberOfRooms = 1;
    private const decimal RoomElectricity = 10;
    
    private decimal laptopCost;

    public AlongYoung(decimal income, decimal laptopCost)
        : base(income, NumberOfRooms, RoomElectricity)
        // using a fields const from above
    {
        this.laptopCost = laptopCost;
    }

    public override decimal Consumption
    {
        get { return base.Consumption + this.laptopCost; }
    }
}
