using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniInjection_E01.Core.RegisteringModules
{
    public class SingleImplementationModule : IRegisteringModule
    {
        public SingleImplementationModule(Assembly assembly)
        {
            this.Assembly = assembly;
        }

        private Assembly Assembly { get; }

        public void Register(IDictionary<Type, Type> types, IDictionary<Type, object> objects)
        {
            Type[] allType = this.Assembly.GetTypes();

            Type[] abstractions = allType
                .Where(t => t.GetTypeInfo().IsInterface)
                .Where(t => t.GetTypeInfo().IsAbstract)
                .ToArray();

            Type[] concreteType = allType
                .Except(abstractions)
                .ToArray();

            foreach (Type abstraction in abstractions)
            {
                Type[] implementations = concreteType
                    .Where(
                            t => t.
                            GetInterfaces()
                            .Contains(abstraction))
                    .ToArray();

                if (implementations.Length != 1)
                {
                    continue;
                }

                Type singleImplementation = implementations[0];

                types[abstraction] = singleImplementation;
            }
        }
    }
}
