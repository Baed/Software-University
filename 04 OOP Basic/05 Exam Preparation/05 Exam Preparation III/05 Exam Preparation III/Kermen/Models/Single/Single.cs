using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Single : HouseHold
{
    protected Single(decimal income, int numbersOfRooms, decimal roomElectricity)
        : base(income, numbersOfRooms, roomElectricity)
    {

    }
}
