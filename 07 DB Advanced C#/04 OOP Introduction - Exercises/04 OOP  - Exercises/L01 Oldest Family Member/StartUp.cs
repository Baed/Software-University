using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using L01_Oldest_Family_Member.Models;

namespace L01_Oldest_Family_Member
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Family family = new Family();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var cmdArgs = Console.ReadLine().Split();

                family.AddMember(new Person(cmdArgs[0], int.Parse(cmdArgs[1])));
            }

            Console.WriteLine(family.GetOldestMember());
        }
    }
}
