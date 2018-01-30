using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Lottary
{
    public Lottary(int number)
    {
        this.Number = number;
    }
    
    public int Number { get; private set; } // DI --> with prop: public int Number { get; set; }

    public string CheckForWin() // DI with parameters --> CheckForWin(int number)
    {
        if (Number < 20)
        {
            return "Sorry you lose!";
        }

        else if (Number >= 20 && 80 < Number)
        {
            return "You can have a new free try";
        }

        else
        {
            return "YOUUUU WINNNN !!!!";
        }
    }
}

