using System;
using System.Globalization;
using System.Linq;
using System.Text;
using E01_SoftUniDB;
using E01_SoftUniDB.Data;
using E01_SoftUniDB.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace E01_SoftUniDB
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var departmentsName = new[] { "Engineering", "Tool Design", "Marketing", "Information Services" };

            using (var context = new SoftuniDbContext())
            {
                var employees = context
                    .Employees
                    .Include(x => x.Department)
                    .Where(x => departmentsName.Contains(x.Department.Name))
                    .OrderBy(x => x.FirstName)
                    .ThenBy(x => x.LastName)
                    .ToList();

                foreach (var employee in employees)
                {
                    employee.Salary += employee.Salary * 0.12m;
                }

                context.SaveChanges();

                var sb = new StringBuilder();

                foreach (var employee in employees)
                {
                    sb.AppendLine($"{employee.FirstName} {employee.LastName} (${employee.Salary:f2})");
                }

                Console.WriteLine(sb.ToString().Trim());
            }
        }
    }
}


// Get-Package
// Update-Package
// Install-Package Microsoft.EntityFrameworkCore.Tools
// Install-Package Microsoft.EntityFrameworkCore.SqlServer
// Install-Package Microsoft.EntityFrameworkCore.SqlServer.Design

//Scaffold-DbContext -Connection: "Data Source = NVG\SQLEXPRESS; Database = SoftUni; Integrated Security = True" -Provider Microsoft.EntityFrameworkCore.SqlServer -OutputDir Data/Models -Context SoftuniDbContext

//Uninstall-Package Microsoft.EntityFrameworkCore.Tools -RemoveDependencies
//Uninstall-Package Microsoft.EntityFrameworkCore.SqlServer.Design -RemoveDependencies


