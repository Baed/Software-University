using System;
using System.Linq;
using E01_SoftUniDB;
using E01_SoftUniDB.Data;
using E01_SoftUniDB.Data.Models;

namespace E01_SoftUniDB
{
    class StartUp
    {
        static void Main(string[] args)
        {
            using (var context = new SoftuniDbContext())
            {
                var employee = context
                    .Employees
                    .OrderBy(e => e.EmployeeId)
                    .ToList();

                foreach (var emp in employee)
                {
                    Console.WriteLine($"{emp.FirstName} {emp.LastName} {emp.MiddleName} {emp.JobTitle} {emp.Salary:f2}");
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


