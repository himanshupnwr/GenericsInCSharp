using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLocator.Services
{
    public interface ICustomerService : IService
    {
        object GetCurrent();
        object CreateOrder(object customer);
    }

    public class CustomerService : ICustomerService
    {
        public object CreateOrder(object customer)
        {
            throw new NotImplementedException();
        }

        public object GetCurrent()
        {
            throw new NotImplementedException();
        }
    }
}
