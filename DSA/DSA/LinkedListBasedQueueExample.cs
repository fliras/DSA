using DataStructures;

namespace DSA
{
    internal static class LinkedListBasedQueue
    {
        static void Main(string[] args)
        {
            LinkedListBasedQueue<int> queue = new LinkedListBasedQueue<int>();
            Console.WriteLine($"is empty: {queue.IsEmpty()}");

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue(6);
            Console.WriteLine($"is empty: {queue.IsEmpty()}");
            Console.WriteLine();

            Console.WriteLine(queue.Peek());
            queue.DeQueue();

            Console.WriteLine(queue.Peek());
            queue.DeQueue();

            Console.WriteLine(queue.Peek());
            queue.DeQueue();

            Console.WriteLine(queue.Peek());
            queue.DeQueue();

            Console.WriteLine(queue.Peek());
            queue.DeQueue();

            queue.DeQueue();
            Console.WriteLine($"is empty: {queue.IsEmpty()}");
            Console.ReadKey();
        }
    }
}
