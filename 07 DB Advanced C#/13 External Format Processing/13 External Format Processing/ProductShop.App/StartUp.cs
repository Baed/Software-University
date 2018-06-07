using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using ProductShop.App.Supports;
using ProductShop.Data;
using ProductShop.Models;

namespace ProductShop.App
{
    class StartUp
    {
        static void Main(string[] args)
        {
           // DbSupport.DbInitializer();

            Engine engine = new Engine();

            engine.Run();
        }
    }
}
