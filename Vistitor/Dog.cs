using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vistitor.Framework;

namespace Vistitor
{
    public class Dog : IElement<Dog>
    {
        public DateTime BirthDate { get; set; }
        public DateTime DatePassed { get; set; }
        public Breed Breed { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public void Accept(IVisitor<Dog> visitor)
        {
            visitor.Visit(this);
        }

    }

    public enum Breed
    {
        Beagle,
        Chihuahua,
        Pug,
    }
}
