namespace E04_WorkForce.Employees
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StandartEmployee : BaseEmployee
    {
        private const int WorkHoursPerWeek = 40;

        public StandartEmployee(string name) 
            : base(name, WorkHoursPerWeek)
        {

        }
    }
}
