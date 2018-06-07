using System;
using System.Linq;
using System.Runtime.CompilerServices;
using L01EntityDemo.Data;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace L01_Entity_Demo
{
    class Program
    {
        static void Main(string[] args)
        {          
            using (var context = new SoftuniDbContext())
            {
                var employees = context.Employees
                    .Select(e => new
                    {
                        FirstName = e.FirstName,
                        LastName = e.LastName,
                        JobTitle = e.JobTitle,
                        ProjectCount = e.EmployeesProjects.Count,
                    })
                    .OrderBy(a => a.JobTitle)
                    .GroupBy(e => e.JobTitle)
                   // .OrderByDescending(a => a.Count())
                    .ToList();

                foreach (var group in employees)
                {
                    Console.WriteLine($"<{group.Key}>");

                    foreach (var emp in group)
                    {
                        Console.WriteLine($"{emp.FirstName} {emp.LastName} - {emp.ProjectCount} projects");
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}

// Get-Package
// Update-Package
// Install-Package Microsoft.EntityFrameworkCore.Tools
// Install-Package Microsoft.EntityFrameworkCore.SqlServer.Design
// Scaffold-DbContext
// Connection: Data Source=NVG\SQLEXPRESS;Database=SoftUni;Integrated Security=True
// Provider Microsoft.EntityFrameworkCore.SqlServer - OutputDir Data/Models - Context SoftuniDbContext

// Scaffold-DbContext -Connection: "Data Source = NVG\SQLEXPRESS; Database = SoftUni; Integrated Security = True" -Provider Microsoft.EntityFrameworkCore.SqlServer -OutputDir Data/Models -Context SoftuniDbContext

