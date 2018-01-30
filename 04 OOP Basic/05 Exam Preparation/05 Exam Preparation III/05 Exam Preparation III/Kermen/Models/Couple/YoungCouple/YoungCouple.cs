using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class YoungCouple : Couple
{
    // A young couple’s home has two rooms, a TV, fridge and a laptop per person. Room’s electricity cost is: 20.

    private const int NumberOfRooms = 2;
    private const decimal RoomElectricity = 20;

    private decimal laptopCost;

    public YoungCouple(decimal salaryOne, decimal salaryTwo, decimal tvCost, decimal fridgeCost, decimal laptopCost)
    : base(NumberOfRooms, RoomElectricity, salaryOne + salaryTwo, tvCost, fridgeCost)

    // we changing the two const varible in above field in this class, in our base metod
    // and changing income with salaryOne + salaryTwo
    {
        this.laptopCost = laptopCost;
    }

    protected YoungCouple(int numberOfRooms, decimal roomElectricity, decimal income, decimal tvCost, decimal fridgeCost, decimal laptopCost)
    : base(numberOfRooms, roomElectricity, income, tvCost, fridgeCost)

        // we build a second constructor for using in class YoungCoupleWithChildren
    {
        this.laptopCost = laptopCost;
    }

    public override decimal Consumption
    {
        get { return base.Consumption  + this.laptopCost * 2; } // a laptop for each adult
    }
}
