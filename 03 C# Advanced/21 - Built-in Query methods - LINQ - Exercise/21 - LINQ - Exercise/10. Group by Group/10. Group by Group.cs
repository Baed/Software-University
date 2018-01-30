using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Group_by_Group
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var students = new List<Person>();

            while (input != "END")
            {
                var tokens = input
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                students.Add(new Person(tokens[0] + " " + tokens[1], int.Parse(tokens[2])));

                input = Console.ReadLine();
            }

            var result = students
                .GroupBy(pr => pr.Group)
                .OrderBy(gr => gr.Key)
                .ToList();

            foreach (var group in result)
            {
                Console.Write(group.Key + " - ");

                var sb = new StringBuilder();

                foreach (var name in group)
                {
                    sb.Append(name.Name).Append(", ");
                }
                sb.Length -= 2;

                Console.WriteLine(sb);
            }
        }
    }
    public class Person
    {
        public string Name { get; set; }
        public int Group { get; set; }

        public Person(string name, int group)
        {
            this.Name = name;
            this.Group = group;
        }
    }
}
