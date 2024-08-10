using DataStructures;

namespace DSA
{
    internal static class LinkedListBasedQueue
    {
        static void Mainha(string[] args)
        {
            LinkedListBasedQueue<int> queue = new LinkedListBasedQueue<int>();

            Console.WriteLine($"queue is empty: {queue.IsEmpty()}"); // true
            queue.Enqueue(13);
            Console.WriteLine($"queue is empty: {queue.IsEmpty()}"); // false

            queue.Enqueue(12);
            queue.Enqueue(11);
            queue.Enqueue(10);
            queue.Enqueue(9);
            queue.Print();

            Console.ReadKey();

            queue.Dequeue();
            queue.Dequeue();
            queue.Print();

            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
            queue.Print();
            Console.WriteLine($"queue is empty: {queue.IsEmpty()}"); // true

            Console.ReadKey();
        }
    }
}
