using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreasDemo.Areas.Shopping.Controllers
{
    [Area("Shopping")]
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
    }
}
