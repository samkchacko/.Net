using System.Collections;

namespace NonGenericCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList
            ArrayList list = new ArrayList();
            list.Add("Sam");
            list.Add(true);
            list.Add(1);
            //Stack PUSH,POP
            Stack items = new Stack();
            items.Push("sam");
            items.Push(true);
            items.Push(1);

            //var value=items.Pop();
            Console.WriteLine(items.Peek());
            //length of the stack
            Console.WriteLine($"Stack Count {items.Count}");

            //
            Queue movies = new Queue();
            movies.Enqueue("Transformers");
            movies.Enqueue("Titanic");
            movies.Enqueue("Johnny English");
            movies.Enqueue("Girl Next Door");
            movies.Enqueue("Gifted");

            movies.Dequeue();

            
        }
    }
}