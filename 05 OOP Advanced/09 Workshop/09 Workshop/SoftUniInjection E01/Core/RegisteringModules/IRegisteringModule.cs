using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniInjection_E01.Core.RegisteringModules
{
    public interface IRegisteringModule
    {
        void Register(IDictionary<Type, Type> types, IDictionary<Type, object> objects);
       
    }
}
