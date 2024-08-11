using DataStructures;

namespace DSA
{
    internal static class LinkedListExample
    {
        static void Mainha(string[] args)
        {
            CustomLinkedList<string> list = new CustomLinkedList<string>();
            list.InsertAtBeginning("def");
            list.InsertAtBeginning("abc");
            list.Print();
            Console.WriteLine();
            Console.ReadKey();


            list.InsertAtEnding("ghi");
            list.InsertAtEnding("jkl");
            list.Print();
            Console.WriteLine();
            Console.ReadKey();


            list.InsertAt(0, "000");
            list.InsertAt(1, "111");
            list.InsertAt(5, "555");
            list.InsertAt(7, "777");
            list.Print();
            Console.WriteLine();
            Console.ReadKey();


            list.DeleteFromBeginning();
            list.DeleteFromEnding();
            list.Print();
            Console.WriteLine();
            Console.ReadKey();


            list.DeleteFrom(5);
            list.DeleteFrom(0);
            list.Print();
            Console.WriteLine();
            Console.ReadKey();


            list.DeleteFrom(1);
            list.Print();
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
