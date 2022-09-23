using System.Collections;

class Example
{
    static void DoArray()
    {
        object[] arr = new[] { new { }, new { }, new { } };

        foreach (object obj in arr)
        {
        }
    }

    // Access items by index
    static void DoList()
    {
        IList arr = new ArrayList(new[] { new { }, new { }, new { } });
        foreach (object obj in arr)
        {
        }
    }

    // Store items as key/value pairs for quick look-up by key  
    static void DoTable()
    {
        Hashtable table = new Hashtable()
        {
            {"key1",new {} },
            {"key2",new {} },
            {"key3",new {} },
        };
    }

    // A sorted collection
    static void DoSortedList()
    {
        SortedList list = new SortedList()
        {
            {"key1",new {} },
            {"key2",new {} },
            {"key3",new {} },
        };
    }

    // Use items first-in-first-out (FIFO)  
    static void DoQueue()
    {
        Queue queue = new Queue(new ArrayList(new[] { new { }, new { }, new { } }));
        while (queue.Peek() != null)
        {
            object obj = queue.Dequeue();
        }
    }

    // Use items last-in-first-out (LIFO)  
    static void DoStack()
    {
        Stack stack = new Stack(new ArrayList(new[] { new { }, new { }, new { } }));
        while (stack.Peek() != null)
        {
            object obj = stack.Pop();
        }
    }

    static void Main(string[] args) { }

}