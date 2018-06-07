namespace L03_Mankind
{
    using System;
    using Models;

    public class Startup
    {
        public static void Main()
        {
            try
            {
                Human student = GetStudent();
                Human worker = GetWorker();
                
                Console.WriteLine(student);

                Console.WriteLine();

                Console.WriteLine(worker);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }

        private static Worker GetWorker()
        {
            var input = Console.ReadLine().Split();

            var firstName = input[0];
            var lastName = input[1];
            var weekSalary = decimal.Parse(input[2]);
            var workHoursPerDay = double.Parse(input[3]);

            return new Worker(firstName, lastName, weekSalary, workHoursPerDay);
        }

        private static Student GetStudent()
        {
            var input = Console.ReadLine().Split();

            var firstName = input[0];
            var lastName = input[1];
            var facultyNumber = input[2];

            return new Student(firstName, lastName, facultyNumber);
        }
    }
}
