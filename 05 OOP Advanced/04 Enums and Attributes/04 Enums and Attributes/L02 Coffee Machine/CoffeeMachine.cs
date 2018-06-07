using System;
using System.Collections.Generic;

public class CoffeeMachine
{
    private int coins;
    private IList<CoffeeType> coffeeSold;

    public CoffeeMachine()
    {
        this.coffeeSold = new List<CoffeeType>();
    }

    public IEnumerable<CoffeeType> CoffeesSold { get { return this.coffeeSold; } }

    public void InsertCoin(string coin)
    {
        Coin coffeeCoins = (Coin)Enum.Parse(typeof(Coin), coin);
        this.coins += (int)coffeeCoins;
    }

    public void BuyCoffee(string size, string type)
    {
        CoffeePrice coffeePrise = (CoffeePrice)Enum.Parse(typeof(CoffeePrice), size);
        CoffeeType coffeeType = (CoffeeType)Enum.Parse(typeof(CoffeeType), type);

        if (this.coins >= (int)coffeePrise)
        {
            this.coffeeSold.Add(coffeeType);
            this.coins = 0;
        }
        else
        {
            Console.WriteLine($"//Comment: first try - not enough coins");
        }
    }
}