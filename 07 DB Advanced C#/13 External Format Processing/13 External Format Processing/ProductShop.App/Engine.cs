using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using ProductShop.Data;
using ProductShop.Models;
using ProductShop.App.Commands;
using ProductShop.App.Commands.Xml;


namespace ProductShop.App
{
    public class Engine
    {
        public Engine()
        {

        }

        public void Run()
        {
            //Import data from Json files      
            //Console.WriteLine(ImportUsersFromJsonCommand.Execute());
            //Console.WriteLine(ImportCategoriesFromJsonCommand.Execute());
            //Console.WriteLine(ImportProductsFromJsonCommand.Execute());

            //01.Products In Range//
            // Console.WriteLine(GetProductsInRange.Execute());

            //02.Successfully Sold Products
            // Console.WriteLine(GetSuccessfullySoldProductCommand.Execute());

            //03.Categories By Products Count
            // Console.WriteLine(GetCategoryByProductsCommand.Execute());

            //04. Users and Products
            //Console.WriteLine(GetUsersAndProductCommand.Execute());

            //Import Data from XML
            //Console.WriteLine(ImportUsersFromXmlCommand.Execute());
            //Console.WriteLine(ImportCategoriesFromXmlCommand.Execute());
            //Console.WriteLine(ImportProductsFromXmlCommand.Execute());

            //01.Products In Range//
            //Console.WriteLine(GetProductsInRangeXmlCommand.Execute());

            //02.Successfully Sold Products
            //Console.WriteLine(GetSuccessfullySoldProductsXmlCommand.Execute());

            //03.Categories By Products Count
            //Console.WriteLine(GetCategoriesByProductsCountXmlCommand.Execute());

            //04. Users and Products
            //Console.WriteLine(GetUsersAndProductsXmlCommand.Execute());
        }
    }
}
