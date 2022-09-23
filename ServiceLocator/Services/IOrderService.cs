using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLocator.Services
{
    public interface IOrderService : IService
    {
        void Save(object order);
    }

    public class OrderService : IOrderService
    {
        public void Save(object order)
        {
            throw new NotImplementedException();
        }
    }
}
