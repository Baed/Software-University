using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniInjection_E01.Core.RegisteringModules
{
    public class ManualRegisteringModule : IRegisteringModule
    {
        private readonly Dictionary<Type, Type> dependencies;
        private readonly Dictionary<Type, object> cache;

        public ManualRegisteringModule()
        {
            this.dependencies = new Dictionary<Type, Type>();
            this.cache = new Dictionary<Type, object>();
        }

        public ManualRegisteringModule Register<TAbstr, TImpl>()
            where TImpl : TAbstr
        {
            this.dependencies[typeof(TAbstr)] = typeof(TImpl);

            return this; // return himself
        }

        public void Register(IDictionary<Type, Type> types, IDictionary<Type, object> objects)
        {
            foreach (KeyValuePair<Type, Type> dependency in this.dependencies)
            {
                types[dependency.Key] = dependency.Value;
            }

            foreach (KeyValuePair<Type, object> catcheObj in this.cache)
            {
                objects[catcheObj.Key] = catcheObj.Value;
            }
        }
    }
}
