using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericsInCSharp.Models;

namespace GenericsInCSharp.Systems
{
    internal class Dumpster
    {
        public IList<Food> Foods { get; } = new List<Food>();
        public IList<Trash> Waste { get; } = new List<Trash>();
        public IList<Bottle> Bottles { get; } = new List<Bottle>();
        public IList<Soda> Liquids { get; } = new List<Soda>();

        public void ProcessAll()
        {
            Process<Food>(Foods, (food) => Composter.GrowKale(food));
            Process<Trash>(Waste, (trash) => SmartIncinerator.Burn(trash));
            Process<Bottle>(Bottles, (bottle) => Melter.MakeFidgetSpinner(bottle));
            Process<Soda>(Liquids, (soda) => Sponge.SoakUp(soda));
        }

        public void Process<T>(IList<T> items, Action<T> disposalMethod)
        {
            foreach (var item in items)
            {
                disposalMethod(item);
            }
        }
    }
}
