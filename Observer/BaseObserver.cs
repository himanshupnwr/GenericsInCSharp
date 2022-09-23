using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class BaseObserver<T> : IObserver<T>
    {
        public Func<T, Reaction> Notify { get; set; }
    }
}
