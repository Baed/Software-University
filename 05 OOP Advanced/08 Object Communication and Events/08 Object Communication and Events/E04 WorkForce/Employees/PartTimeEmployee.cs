namespace E04_WorkForce.Employees
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class PartTimeEmployee : BaseEmployee
    {
        private const int WorkHoursPerWeek = 20;

        public PartTimeEmployee(string name)
            : base(name, WorkHoursPerWeek)
        {
        }
    }
}
