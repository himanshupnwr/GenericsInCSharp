using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class ChewingObserver : BaseObserver<Dog>
    {
        public Reaction OnChewing(object objChewed)
        {
            if (objChewed is Sprinkler)
            {
                return Reaction.BadDog;
            }

            return Reaction.GoodGirl;
        }
    }
}
