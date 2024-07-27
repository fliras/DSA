using DataStructures;

namespace DSA
{
    internal static class LinkedListExample
    {
        static void Main(string[] args)
        {
            MyLinkedList list = new MyLinkedList();
            list.PutAtEnd(1);
            list.PutAtEnd(2);
            list.PutAtEnd(3);
            list.PutAtEnd(4);
            list.Print();

            list.PutAtBeginning(0);
            list.PutAtBeginning(-1);
            list.PutAtBeginning(-2);
            Console.WriteLine("linked list after inserting 0, -1, and -2:");
            list.Print();

            list.DeleteNode(3);
            Console.WriteLine("linked list after deleting position 3:");
            list.Print();

            list.DeleteNode(0);
            Console.WriteLine("linked list after deleting position 0:");
            list.Print();
        }
    }
}
