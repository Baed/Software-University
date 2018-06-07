using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreasDemo.Areas.Products.Controllers
{
    [Area("Products")]
    public class CategoriesController : Controller
    {
        public IActionResult Create() => View();
    }
}
