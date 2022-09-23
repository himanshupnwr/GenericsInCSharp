using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Observer
{
    public class Dog
    {
        public IList<IObserver<Dog>> Observers { get; } = new List<IObserver<Dog>>();
        public object ObjectFound { get; set; }

        public void Attach(IObserver<Dog> observer)
        {
            Observers.Add(observer);
        }

        private void Found(object found)
        {
            ObjectFound = found;
            foreach (var observer in Observers)
            {
                observer.Notify(this);
            }
        }

        public void Run()
        {
            if (DateTime.Now.Millisecond % 3 == 0)
            {
                Found(new Sprinkler());
            }
            else
            {
                Found(new Bone());
            }
        }
    }
}
