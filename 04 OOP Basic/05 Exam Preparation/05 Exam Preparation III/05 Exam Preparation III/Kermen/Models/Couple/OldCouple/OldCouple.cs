
public class OldCouple : Couple
{
    // An old couple has three rooms, a TV, fridge and stove. 
    // Room’s electricity cost is: 15.

    private const int NumberOfRooms = 3;
    private const decimal RoomElectricity = 15;

    private decimal stoveCost;

    public OldCouple(decimal pensionOne, decimal pensionTwo, decimal tvCost, decimal fridgeCost, decimal stoveCost)
        : base(NumberOfRooms, RoomElectricity, pensionOne + pensionTwo, tvCost, fridgeCost)
    {
        this.stoveCost = stoveCost;
    }

    public override decimal Consumption
    {
        get { return base.Consumption + this.stoveCost; }
    }
}
