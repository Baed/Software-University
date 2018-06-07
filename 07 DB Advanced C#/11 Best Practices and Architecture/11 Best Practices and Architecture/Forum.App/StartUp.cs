using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Forum.Data;
using Forum.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Forum.Servises;
using Forum.Servises.Contracts;
using Microsoft.Extensions.DependencyInjection;

namespace Forum.App
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Engine engine = new Engine();
            
            engine.Run();
            
            engine.ExecuteCommand();
        }
    }
}

// Install-Package Microsoft.EntityFrameworkCore.SqlServer
// Install-Package Microsoft.EntityFrameworkCore.Tools
// Install-Package Microsoft.Extensions.DependencyInjection
// Update-Database
// Drop-Database
// Add-Migration Initial
// Remove-Migration
// Update-Database -Migration: "Initial"