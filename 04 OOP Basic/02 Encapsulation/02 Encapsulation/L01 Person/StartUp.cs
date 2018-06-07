using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class StartUp
{
    public static void Main(string[] args)
    {
        int numOfPersons = int.Parse(Console.ReadLine());

        var personsList = new List<Person>();

        for (int i = 0; i < numOfPersons; i++)
        {
            var cmdArgs = Console.ReadLine().Split(' ');

            var person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]));

            personsList.Add(person);
        }

        personsList
            .OrderBy(p => p.FirstName)
            .ThenBy(p => p.Age)
            .ToList()
            .ForEach(p => Console.WriteLine(p.ToString()));
    }
}
