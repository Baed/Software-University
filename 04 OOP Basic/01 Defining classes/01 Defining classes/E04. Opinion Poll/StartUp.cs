using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E04.Opinion_Poll
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfPersons = int.Parse(Console.ReadLine());

            var personsList = new List<Person>();

            for (int i = 0; i < numberOfPersons; i++)
            {
                var personInfo = Console.ReadLine().Split(' ');

                var person = new Person(personInfo[0], int.Parse(personInfo[1]));

                personsList.Add(person);
            }

            personsList
                .Where(p => p.Age > 30)
                .OrderBy(p => p.Name)
                .ToList()
                .ForEach(p => Console.WriteLine(p.ToString()));
        }
    }
}
