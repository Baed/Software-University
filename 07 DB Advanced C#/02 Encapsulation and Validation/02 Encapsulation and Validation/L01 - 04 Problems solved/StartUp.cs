namespace L01___04_Problems_solved
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class StartUp
    {
        public static void Main()
        {
            Team team = new Team();

           // var persons = new List<Person>();

            var lines = int.Parse(Console.ReadLine());

            while (lines-- > 0)
            {
                var cmdArgs = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                try
                {
                    var person = new Person(cmdArgs[0], 
                                            cmdArgs[1], 
                                            int.Parse(cmdArgs[2]), 
                                            double.Parse(cmdArgs[3]));

                   // persons.Add(person);
                    team.AddPlayer(person);

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

           // var bonus = double.Parse(Console.ReadLine());
           //
           // persons.ForEach(p => p.IncreaseSalary(bonus));
           //
           // persons.ForEach(p => Console.WriteLine(p.ToString()));

            Console.WriteLine(team);
        }
    }
}
