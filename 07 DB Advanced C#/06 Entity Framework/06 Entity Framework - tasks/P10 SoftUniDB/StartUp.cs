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
            using (var context = new SoftuniDbContext())
            {
                var departmentInfo = context
                    .Departments
                    .Where(d => d.Employees.Count > 5)
                    .OrderBy(e => e.Employees.Count)
                    .Select(a => new
                    {
                        Name = a.Name,
                        Manager = a.Manager.FirstName + " " + a.Manager.LastName,
                        EmployeeName = a.Employees.Select(e => new
                        {
                            FirstName = e.FirstName,
                            LastName = e.LastName,
                            Job = e.JobTitle
                        })
                    });

                StringBuilder sb = new StringBuilder();

                foreach (var dpm in departmentInfo)
                {
                    sb.AppendLine(($"{dpm.Name} - {dpm.Manager}"));

                    foreach (var emp in dpm.EmployeeName.OrderBy(e => e.FirstName).ThenBy(e => e.LastName))
                    {
                        sb.AppendLine($"{emp.FirstName} {emp.LastName} - {emp.Job}");
                    }

                    sb.AppendLine(new string('-', 10));
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


