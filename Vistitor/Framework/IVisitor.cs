using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vistitor.Framework
{
    public interface IVisitor<T>
    {
        void Visit(T element);
    }

}
