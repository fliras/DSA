using DataStructures;

namespace DSA
{
    internal static class ArrayBasedQueueExample
    {
        static void Mainha(string[] args)
        {
            CustomArrayBasedQueue<int> queue = new CustomArrayBasedQueue<int>(5);

            Console.WriteLine($"queue is empty: {queue.IsEmpty()}"); // true
            Console.WriteLine($"queue is full: {queue.IsFull()}"); // false
            queue.Enqueue(13);
            Console.WriteLine($"queue is empty: {queue.IsEmpty()}"); // false

            queue.Enqueue(12);
            queue.Enqueue(11);
            queue.Enqueue(10);
            queue.Enqueue(9);
            Console.WriteLine($"queue is full: {queue.IsFull()}"); // true
            queue.Print();

            Console.ReadKey();

            queue.Dequeue();
            queue.Dequeue();
            Console.WriteLine($"queue is full: {queue.IsFull()}"); // false
            queue.Print();

            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
            queue.Print();
            Console.WriteLine($"queue is full: {queue.IsFull()}"); // false
            Console.WriteLine($"queue is full: {queue.IsEmpty()}"); // true

            Console.ReadKey();
        }
    }
}
