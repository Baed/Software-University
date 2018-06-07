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
                var projects = context
                    .Projects
                    .OrderByDescending(x => x.StartDate)
                    .Take(10)
                    .OrderBy(x => x.Name)
                    .Select(x => new
                    {
                        x.Name,
                        x.Description,
                        x.StartDate
                    })
                    .ToList();

                var sb = new StringBuilder();
                foreach (var project in projects)
                {
                    sb.AppendLine(project.Name);
                    sb.AppendLine(project.Description);
                    sb.AppendLine(project.StartDate.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture));
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


