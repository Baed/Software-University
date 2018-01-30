using SoftUniInjection_E01.Repositories;
using SoftUniInjection_E01.Servises;
using SoftUniInjection_E01.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftUniInjection_E01.Core.RegisteringModules;
using System.Reflection;

namespace SoftUniInjection_E01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Container container = new Container(
                new SingleImplementationModule(Assembly.GetEntryAssembly()),
                 new ManualRegisteringModule()
                                 .Register<ISoftUniRepository, DefautSoftUniRepository>());

            IUserServise userServise = container.Get<IUserServise>();

            userServise.Rename();
        }
    }
}
