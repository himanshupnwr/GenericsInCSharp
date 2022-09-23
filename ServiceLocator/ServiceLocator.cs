using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLocator.Services;

namespace ServiceLocator
{
    public class ServiceLocator
    {
        private IDictionary<Type, IService> _registry = new Dictionary<Type, IService>();

        public void AddService<TServiceType, TServiceClass>() where TServiceType : IService where TServiceClass : TServiceType
        {
            _registry[typeof(TServiceType)] = Activator.CreateInstance<TServiceClass>();
        }

        public T CreateService<T>()
        {
            return (T)_registry[typeof(T)];
        }
    }
}
