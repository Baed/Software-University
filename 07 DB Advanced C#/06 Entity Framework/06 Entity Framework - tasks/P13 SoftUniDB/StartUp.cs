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
                    .Where(x => x.FirstName.StartsWith("Sa"))
                    .OrderBy(x => x.FirstName)
                    .ThenBy(x => x.LastName)
                    .Select(x => new
                    {
                        Name = $"{x.FirstName} {x.LastName} - {x.JobTitle} - (${x.Salary:f2})"
                    })
                    .ToList();

                employees.ForEach(x => Console.WriteLine($"{x.Name}"));
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


