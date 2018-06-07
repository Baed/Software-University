using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Launcher.cs.Server.Contracts;

namespace Launcher.cs.Server.Common
{
    public class NotFoundView : IView
    {
        public string View()
        {
            return "<h1>404 This page does not exist :/</h1>";
        }
    }
}