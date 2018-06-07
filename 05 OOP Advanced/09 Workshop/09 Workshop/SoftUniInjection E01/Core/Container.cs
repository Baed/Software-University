using SoftUniInjection_E01.Servises;
using SoftUniInjection_E01.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using SoftUniInjection_E01.Core.RegisteringModules;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniInjection_E01.Core
{
    public class Container
    {
        private Dictionary<Type, Type> dependencies;

        private Dictionary<Type, object> cache;

        public Container(params IRegisteringModule[] modules)
        {
            this.dependencies = new Dictionary<Type, Type>();
            this.cache = new Dictionary<Type, object>();
            this.InvokeModules(modules);
        }

        private void InvokeModules(IRegisteringModule[] modules)
        {
            foreach (IRegisteringModule module in modules)
            {
                module.Register(this.dependencies, this.cache);
            }
        }

        public T Get<T>()
        {
            var interfaceType = typeof(T);

            if (!interfaceType.GetTypeInfo().IsInterface
                && !interfaceType.GetTypeInfo().IsAbstract)
            {
                throw new Exception("We can only make DI with Interfaces! You should depend on abstraction!");
            }

            return (T)this.Get(interfaceType);
        }

        private object Get(Type interfaceType)
        {
            if (this.cache.ContainsKey(interfaceType))
            {
                return this.cache[interfaceType];
            }

            Type concreteType = this.dependencies[interfaceType];

            ConstructorInfo ctorInfo = concreteType.GetConstructors().FirstOrDefault();

            ParameterInfo[] paramArgs = ctorInfo.GetParameters();

            object[] argsToPassToCtor = new object[paramArgs.Length];

            List<object> argsList = new List<object>();

            foreach (ParameterInfo paramArg in paramArgs)
            {
                Type paramArgType = paramArg.ParameterType;

                object obj = this.Get(paramArgType);
                argsList.Add(obj);
            }

            object objToCache = ctorInfo.Invoke(argsList.ToArray());

            this.cache[interfaceType] = objToCache;

            return objToCache;
        }
    }
}
