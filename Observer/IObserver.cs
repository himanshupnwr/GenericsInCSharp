using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public interface IObserver<T>
    {
        System.Func<T, Reaction> Notify { get; set; }
    }
}
