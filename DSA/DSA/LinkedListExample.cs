using DataStructures;

namespace DSA
{
    internal static class LinkedListExample
    {
        static void Main(string[] args)
        {
            CustomLinkedList<string> list = new CustomLinkedList<string>();
            list.InsertAtBeginning("def");
            list.InsertAtBeginning("abc");
            list.Print();
            Console.WriteLine();

            list.InsertAtEnd("ghi");
            list.InsertAtEnd("jkl");
            list.Print();
            Console.WriteLine();

            list.InsertAt(0, "000");
            list.InsertAt(1, "111");
            list.InsertAt(5, "555");
            list.InsertAt(7, "777");
            list.Print();
            Console.WriteLine();

            list.DeleteFromBeginning();
            list.DeleteFromEnd();
            list.Print();
            Console.WriteLine();

            list.DeleteAt(5);
            list.DeleteAt(0);
            list.Print();
            Console.WriteLine();

            list.DeleteAt(1);
            list.Print();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
