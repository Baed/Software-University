using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Launcher.cs.Server.Contracts;

namespace Launcher.cs.Application.Home.View
{
    public class IndexView : IView
    {
        public string View() => "<h1>Welcome!</h1>";
    }
}