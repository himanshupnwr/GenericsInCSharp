using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vistitor.Framework;

namespace Vistitor
{
    public class CalculateDogAge : IVisitor<Dog>
    {
        public void Visit(Dog dog)
        {
            dog.Age = dog.DatePassed.Year - dog.BirthDate.Year;
        }

    }
}
