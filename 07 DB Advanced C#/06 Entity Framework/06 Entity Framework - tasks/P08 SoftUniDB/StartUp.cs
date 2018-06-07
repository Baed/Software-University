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
                var adresses = context
                                     .Addresses
                                     .Include(x => x.Town)
                                     .Include(x => x.Employees)
                                     .OrderByDescending(x => x.Employees.Count)
                                     .ThenBy(x => x.Town.Name)
                                     .ThenBy(x => x.AddressText)
                                     .Take(10)
                                     .ToList();

                adresses.ForEach(x => Console.WriteLine($"{x.AddressText}, {x.Town.Name} - {x.Employees.Count} employees"));
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


