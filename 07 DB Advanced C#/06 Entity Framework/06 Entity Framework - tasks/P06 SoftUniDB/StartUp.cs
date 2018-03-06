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
                var address = new Address();
                address.AddressText = "Vitoshka 15";
                address.TownId = 4;



                var employees = context
                    .Employees
                    .Where(e => e.LastName.Equals("Nakov"))
                    .ToList();

                for (int i = 0; i < employees.Count; i++)
                {
                    employees[i].Address = address;
                }

                var addressNames = context
                    .Employees
                    .OrderByDescending(x => x.AddressId)
                    .Take(10)
                    .Select(x => x.Address.AddressText)
                    .ToList();

                addressNames.ForEach(x => Console.WriteLine(x));
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


