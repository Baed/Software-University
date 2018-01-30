using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class YoungCoupleWithChildren : YoungCouple
{
    // A young couple with children has two rooms, a TV, fridge, laptop
    // per each adult and toys for each child. Room’s electricity cost is: 30.

    private const int NumberOfRooms = 2;
    private const decimal RoomElectricity = 30;

    private Child[] children;

    public YoungCoupleWithChildren(decimal salaryOne, decimal salaryTwo, decimal tvCost, decimal fridgeCost, decimal laptopCost,Child[] children) 
        : base(NumberOfRooms, RoomElectricity, salaryOne + salaryTwo, tvCost, fridgeCost, laptopCost)
        // we use a second constructor of mother class for base value;
    {
        this.children = children;
    }

    public override decimal Consumption
    {
        get { return base.Consumption + this.children.Sum(x => x.GetTotalConsumption()); }
    }

    public override int Population
    {
        get { return base.Population + this.children.Length; }
    }
}
