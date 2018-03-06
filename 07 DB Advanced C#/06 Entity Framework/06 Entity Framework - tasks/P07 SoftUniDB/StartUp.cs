using System;
using System.Globalization;
using System.Linq;
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
            using (var context = new SoftuniDbContext())
            {
                var employeesInfo = context
                             .Employees
                             .Include(e => e.Manager)
                             .Include(e => e.EmployeesProjects)
                             .ThenInclude(e => e.Project)
                             .Where(e => e.EmployeesProjects.Any(ep => ep.Project.StartDate.Year >= 2001 ||
                                                                       ep.Project.StartDate.Year >= 2003))
                             .Take(30)
                             .ToList();

                foreach (var employee in employeesInfo)
                {
                    Console.WriteLine($"{employee.FirstName} {employee.LastName} – Manager: {employee.Manager.FirstName} {employee.Manager.LastName}");

                    foreach (var empProject in employee.EmployeesProjects)
                    {
                        var endDate = empProject.Project.EndDate is null
                            ? "not finished"
                            : empProject.Project.EndDate.Value.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);

                        Console.WriteLine($"--{empProject.Project.Name} - {empProject.Project.StartDate.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture)} - {endDate}");
                    }
                }
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


