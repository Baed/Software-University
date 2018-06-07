using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Launcher.cs.Server.Contracts;

namespace Launcher.cs.Infrastructure
{
    public class FileView : IView
    {
        private readonly string htmlFile;

        public FileView(string htmlFile)
        {
            this.htmlFile = htmlFile;
        }

        public string View() => this.htmlFile;
    }
}