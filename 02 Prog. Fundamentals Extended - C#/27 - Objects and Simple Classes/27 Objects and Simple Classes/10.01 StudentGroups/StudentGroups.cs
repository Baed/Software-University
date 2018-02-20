using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _10._01_StudentGroups
{
    class StudentGroups
    {
        static void Main(string[] args)
        {
            List<Town> townsList = TownReader();

            List<Group> groupsList = GroupReader(townsList);

            Writer(groupsList);
        }

        private static void Writer(List<Group> groupsList)
        {
            int townsCount = groupsList.Select(x => x.Town).Distinct().Count();

            Console.WriteLine($"Created {groupsList.Count} groups in {townsCount} towns:");

            foreach (var group in groupsList.OrderBy(x => x.Town.Name))
            {
                Console.Write($"{group.Town.Name} => ");

                Console.WriteLine($"{string.Join(", ", group.Students.Select(x => x.Email))}");
            }
        }

        private static List<Group> GroupReader(List<Town> townsList)
        {
            List<Group> groupsList = new List<Group>();

            foreach (var town in townsList.OrderBy(t => t.Name))
            {
                IEnumerable<Student> students = town
                                 .Students
                                 .OrderBy(s => s.RegistrationDate)
                                 .ThenBy(s => s.Name)
                                 .ThenBy(s => s.Email);

                while (students.Any())
                {
                    Group group = new Group();
                    group.Town = town;
                    group.Students = students.Take(group.Town.Seats).ToList();
                    students = students.Skip(group.Town.Seats);
                    groupsList.Add(group);
                }
            }


            return groupsList;
        }


        static List<Town> TownReader()
        {
            List<Town> townsList = new List<Town>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                if (input.Contains("=>"))
                {
                    var inputTownInfo = input.Split(new[] { " => " }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToList();
                    string town = inputTownInfo[0];
                    var tokens = inputTownInfo[1].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    int seats = int.Parse(tokens[0]);

                    Town townData = new Town(town, seats, new List<Student>());
                    townsList.Add(townData);
                }
                else
                {
                    var inputStudentInfo = input.Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToList();
                    string name = inputStudentInfo[0];
                    string email = inputStudentInfo[1];
                    DateTime date = DateTime.ParseExact(inputStudentInfo[2], "d-MMM-yyyy", CultureInfo.InvariantCulture);

                    Student studentsData = new Student(name, email, date);
                    townsList.LastOrDefault().Students.Add(studentsData);
                }
            }

            return townsList;
        }
    }

    class Student
    {
        public Student(string name, string email, DateTime registrationDate)
        {
            this.Name = name;
            this.Email = email;
            this.RegistrationDate = registrationDate;
        }

        public string Name { get; set; }

        public string Email { get; set; }

        public DateTime RegistrationDate { get; set; }
    }

    class Town
    {
        public Town(string name, int seats, List<Student> students)
        {
            this.Name = name;
            this.Seats = seats;
            this.Students = students;
        }

        public string Name { get; set; }

        public int Seats { get; set; }

        public List<Student> Students { get; set; }
    }

    class Group
    {
        public Town Town { get; set; }

        public List<Student> Students { get; set; }
    }
}
