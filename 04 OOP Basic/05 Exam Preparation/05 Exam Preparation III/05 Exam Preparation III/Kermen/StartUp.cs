using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class StartUp
{
    public static void Main()
    {
        List<HouseHold> kermen = new List<HouseHold>();

        string input;
        int cnt = 0;
        while ((input = Console.ReadLine()) != "Democracy")
        {
            cnt++;
            try
            {
                HouseHold entity = Factory.CreateHouseHold(input);
                kermen.Add(entity);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            if (cnt % 3 == 0)
            {
                kermen.ForEach(hh => hh.GetIncome()); // get salary
            }

            if (input == "EVN bill")
            {
                kermen.RemoveAll(x => !x.CanPayBills()); // if they can pay there are bills
                kermen.ForEach(x => x.PayBills()); // if can, they pay it
                /*
                 foreach (var houseHold in kermen)
                 {
                 if (houseHold.CanPayBills()) { houseHold.PayBills(); }
                 }
                 */
            }
            else if (input == "EVN")
            {
                Console.WriteLine($"Total consumption: {kermen.Sum(x => x.Consumption)}");
            }
        }

        Console.WriteLine($"Total population: {kermen.Sum(x => x.Population) }");

    }
}

