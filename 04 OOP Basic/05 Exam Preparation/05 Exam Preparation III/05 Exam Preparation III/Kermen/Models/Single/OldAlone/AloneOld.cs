using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class AloneOld : Single
{
    // An alone old person has a room and only memories of the past life.
    // Room’s electricity cost is: 15.

    private const int NumberOfRooms = 1;
    private const decimal RoomElectricity = 15;

    public AloneOld(decimal pension)
        : base(pension, NumberOfRooms, RoomElectricity)
    // using a fields const from above
    {
        // this fild and methods are empty because we do not have any consumptions;
    }
}

