using DataStructures;

namespace DSA
{
    internal static class ArrayBasedQueueExample
    {
        static void Main(string[] args)
        {
            CustomArrayBasedQueue<int> queue = new CustomArrayBasedQueue<int>(5);
            Console.WriteLine($"is empty: {queue.IsEmpty()}");

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            Console.WriteLine($"is empty: {queue.IsEmpty()}");
            Console.WriteLine($"is full: {queue.IsFull()}");

            queue.Enqueue(5);
            Console.WriteLine($"is full: {queue.IsFull()}");
            queue.Enqueue(6);

            queue.Print();
            Console.WriteLine();

            queue.DeQueue();
            queue.DeQueue();
            queue.DeQueue();
            queue.DeQueue();
            queue.DeQueue();
            Console.WriteLine($"is empty: {queue.IsEmpty()}");
            Console.ReadKey();
        }
    }
}
