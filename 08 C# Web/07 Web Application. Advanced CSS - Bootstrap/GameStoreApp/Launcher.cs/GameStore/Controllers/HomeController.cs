using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Launcher.cs.Server.Http.Contracts;

namespace Launcher.cs.GameStore.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(IHttpRequest request)
            : base(request)
        {
        }

        public IHttpResponse Index()
        {
            return this.FileViewResponse(@"home\index");
        }
    }
}