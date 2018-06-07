using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class HouseHold
{
    private int numbersOfRooms;
     private decimal roomElectricity;
    private readonly decimal income;
    private decimal balance;
    
    protected HouseHold(decimal income, int numbersOfRooms, decimal roomElectricity)
    {
        this.balance = 0;
        this.income = income;
        this.numbersOfRooms = numbersOfRooms;
        this.roomElectricity = roomElectricity;
    }

    public virtual int Population
    {
        get { return 1; }       
    }

    public virtual decimal Consumption
    {
        get { return this.roomElectricity * this.numbersOfRooms; }
    }

    public void GetIncome()
    {
        this.balance += this.income;
    }

    public bool CanPayBills()
    {
        return this.balance >= this.Consumption;
    }

    public void PayBills()
    {
        this.balance -= this.Consumption;
    }
}
