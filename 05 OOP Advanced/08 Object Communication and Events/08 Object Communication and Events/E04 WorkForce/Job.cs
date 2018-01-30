namespace E04_WorkForce
{
    using E04_WorkForce.Employees;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using static E04_WorkForce.StartUp;

    public class Job
    {
        public event JobDoneEventHandler JobDone;

        public Job(string name, int workHoursRequired, BaseEmployee employee)
        {
            this.Name = name;
            this.WorkHoursRequired = workHoursRequired;
            this.Employee = employee;
            this.IsDone = false;
        }

        public string Name { get; private set; }

        public int WorkHoursRequired { get; private set; }

        public BaseEmployee Employee { get; private set; }

        public bool IsDone { get; private set; }

        public void Update()
        {
            this.WorkHoursRequired -= Employee.WorkHoursPerWeek;

            if (this.WorkHoursRequired <= 0 && !this.IsDone)
            {
                if (JobDone != null)
                {
                    JobDone(this, new JobEventArgs(this));
                }
            }
        }

        public void OnJobDone(object sender, JobEventArgs e)
        {
            Console.WriteLine($"Job {this.Name} done!");
            IsDone = true;
        }

        public override string ToString()
        {
            return $"Job: {this.Name} Hours Remaining: {this.WorkHoursRequired}";
        }
    }
}
