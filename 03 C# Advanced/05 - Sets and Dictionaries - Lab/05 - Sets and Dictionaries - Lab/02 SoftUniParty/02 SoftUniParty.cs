using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine();

            var invitedGuests = new SortedSet<string>();

            while (input != "PARTY")
            {
                invitedGuests.Add(input);

                input = Console.ReadLine();
            }

            while (input != "END")
            {
                invitedGuests.Remove(input);

                input = Console.ReadLine();
            }

            Console.WriteLine(invitedGuests.Count);

            foreach (var guest in invitedGuests)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
