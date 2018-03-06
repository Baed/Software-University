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
                var employeeInfo = context
                                     .Employees
                                     .Include(p => p.EmployeesProjects)
                                     .ThenInclude(p => p.Project)
                                     .Where(e => e.EmployeeId.Equals(147))
                                     .Select(e => new
                                     {
                                         Name = $"{e.FirstName} {e.LastName}",
                                         JobTitle = e.JobTitle,
                                         Projects = e.EmployeesProjects
                                     })
                                     .FirstOrDefault(); // SingleOrDefault


                Console.WriteLine($"{employeeInfo.Name} - {employeeInfo.JobTitle}");

                foreach (var empProject in employeeInfo.Projects.OrderBy(x => x.Project.Name))
                {
                    Console.WriteLine($"{empProject.Project.Name}");
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


