using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeParameters
{
    public class SmartIncinerator<T> where T: Enum // where T:Trash or where T : new(), or T:struct, or T: class this is called constraints
    {
        public Action<T> DestroyMethod { get; }

        public void Burn(T burnable)
        {
            DestroyMethod(burnable);
        }
    }

    public enum Trashables
    {
        BubbleGum, 
        CandyWrappers,
        LotteryTickets
    }

    //when T is a struct
    //public class IntIncinerator : SmartIncinerator<int>
    //{

    //}

    //public class TrashIncinerator : SmartIncinerator<Trash>
    //{

    //}
    public class TrashIncinerator : SmartIncinerator<Trashables>
    {

    }

    public class Trash : IBurnable
    {
        public Trash(object obj)
        {

        }

        public void Crumple()
        {
            throw new NotImplementedException();
        }
    }
}
