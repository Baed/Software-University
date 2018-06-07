using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

static class Factory
{
    public static HouseHold CreateHouseHold(string input)
    {
        string pattern = @"(\w+)\(([\d\.\s,]+)\)";
        Regex rgx = new Regex(pattern);
        var matches = rgx.Matches(input);

        if (rgx.IsMatch(input))
        {
            string houseHoldType = matches[0].Groups[1].Value;
            if (houseHoldType == "YoungCouple")
            {
                return CreateYoungCoupe(matches);
            }
            else if (houseHoldType == "YoungCoupleWithChildren")
            {
                return GetYoungCoupleWithChildren(matches);
            }
            else if (houseHoldType == "AloneYoung")
            {
                return GetYoungAlone(matches);
            }
            else if (houseHoldType == "OldCouple")
            {
                return GetOldCouple(matches);
            }
            else if (houseHoldType == "AloneOld")
            {
                return GetOldAlone(matches);
            }
            else
            {
                throw new ArgumentException($"Invalid input");
            }
        }

        throw new ArgumentException($"Invalid household");
    }

    private static HouseHold GetOldAlone(MatchCollection matches)
    {
        var pension = decimal.Parse(matches[0].Groups[2].Value);

        return new AloneOld(pension);
    }

    private static HouseHold GetOldCouple(MatchCollection matches)
    {
        var pensions = matches[0].Groups[2].Value
            .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(decimal.Parse)
            .ToArray();

        var tvCost = decimal.Parse(matches[1].Groups[2].Value);
        var fridgeCost = decimal.Parse(matches[2].Groups[2].Value);
        var stoveCost = decimal.Parse(matches[3].Groups[2].Value);

        return new OldCouple(pensions[0], pensions[1], tvCost, fridgeCost, stoveCost);
    }

    private static HouseHold GetYoungAlone(MatchCollection matches)
    {
        var salary = decimal.Parse(matches[0].Groups[2].Value);
        var laptopCost = decimal.Parse(matches[1].Groups[2].Value);

        return new AlongYoung(salary, laptopCost);
    }

    private static HouseHold GetYoungCoupleWithChildren(MatchCollection matches)
    {
        var salaries = matches[0].Groups[2].Value
                            .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(decimal.Parse)
                            .ToArray();

        var tvCost = decimal.Parse(matches[1].Groups[2].Value);
        var fridgeCost = decimal.Parse(matches[2].Groups[2].Value);
        var laptopCost = decimal.Parse(matches[3].Groups[2].Value);

        Child[] children = new Child[matches.Count - 4]; // we have four matches before
        for (int i = 4; i < matches.Count; i++)
        {
            // for each child we get him consumptions
            var childConsumptions = matches[i].Groups[2].Value // !!! matches[i] !!!
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(decimal.Parse)
                .ToArray();

            children[i - 4] = new Child(childConsumptions);
        }

        return new YoungCoupleWithChildren(salaries[0], salaries[1], tvCost, fridgeCost, laptopCost, children);
    }

    private static HouseHold CreateYoungCoupe(MatchCollection matches)
    {
        var salaries = matches[0].Groups[2].Value
            .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(decimal.Parse)
            .ToArray();

        var tvCost = decimal.Parse(matches[1].Groups[2].Value);
        var fridgeCost = decimal.Parse(matches[2].Groups[2].Value);
        var laptopCost = decimal.Parse(matches[3].Groups[2].Value);

        return new YoungCouple(salaries[0], salaries[1], tvCost, fridgeCost, laptopCost);
    }
}

