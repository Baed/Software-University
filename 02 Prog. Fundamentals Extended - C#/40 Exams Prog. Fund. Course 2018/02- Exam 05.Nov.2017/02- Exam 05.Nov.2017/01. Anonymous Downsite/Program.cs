using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _01.Anonymous_Downsite
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfsites = int.Parse(Console.ReadLine());

            int securityKey = int.Parse(Console.ReadLine());

            List<string> siteList = new List<string>();

            decimal siteLoss = 0m;

            for (int i = 0; i < numOfsites; i++)
            {
                var cmdArgs = Console.ReadLine().Split();

                siteList.Add(cmdArgs[0]);
                long siteVisits = long.Parse(cmdArgs[1]);
                decimal siteCommercialPricePerVisit = decimal.Parse(cmdArgs[2]);

                siteLoss += siteVisits * siteCommercialPricePerVisit;
            }

            Console.WriteLine(string.Join(Environment.NewLine, siteList));

            Console.WriteLine($"Total Loss: {siteLoss:f20}");

            Console.WriteLine($"Security Token: {BigInteger.Pow(new BigInteger(securityKey), numOfsites)}");
        }
    }
}
