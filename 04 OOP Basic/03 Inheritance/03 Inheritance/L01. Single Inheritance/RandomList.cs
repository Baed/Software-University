using System;
using System.Collections;

public class RandomList : ArrayList // ArrayList --> using System.Collections;
{
    private Random rnd;

    public RandomList()
    {
        this.rnd = new Random();
    }

    public string RandomString()
    {
        return "";
    }
}

