using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsAndGenerics
{
    internal class GenericCollectionExample<T> where T : new()
    {
        static void DoArray()
        {
            T[] arr = new T[] { new T(), new T(), new T() };

            foreach (T obj in arr)
            {
            }
        }

        // Access items by index
        static void DoList()
        {
            IList<T> arr = new List<T>(new T[] { new T(), new T(), new T() });
            foreach (T obj in arr)
            {
            }
        }

        // Store items as key/value pairs for quick look-up by key  
        static void DoTable<TKey>() where TKey : new()
        {
            IDictionary<TKey, T> table = new Dictionary<TKey, T>
            {
                {new TKey(), new T()},
                {new TKey(), new T()},
                {new TKey(), new T()}
            };
        }

        // A sorted collection
        static void DoSortedList<TKey>() where TKey : new()
        {
            SortedList<TKey, T> list = new SortedList<TKey, T>()
            {
                {new TKey(), new T()},
                {new TKey(), new T()},
                {new TKey(), new T()}
            };
        }

        // Use items first-in-first-out (FIFO)  
        static void DoQueue()
        {
            Queue<T> queue = new Queue<T>(new T[] { new T(), new T(), new T() });
            while (queue.Count > 0)
            {
                T obj = queue.Dequeue();
            }
        }

        // Use items last-in-first-out (LIFO)  
        static void DoStack()
        {
            Stack<T> stack = new Stack<T>(new T[] { new T(), new T(), new T() });
            while (stack.Peek() != null)
            {
                T obj = stack.Pop();
            }
        }

        static void Main(string[] args) { }
    }
}
