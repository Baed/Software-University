using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Launcher.cs.Server.Contracts;

namespace Launcher.cs.Server.Common
{
    public class InternalServerErrorView : IView
    {
        private readonly Exception exception;

        public InternalServerErrorView(Exception exception)
        {
            this.exception = exception;
        }

        public string View()
        {
            return $"<h1>{this.exception.Message}</h1><h2>{this.exception.StackTrace}</h2>";
        }
    }
}