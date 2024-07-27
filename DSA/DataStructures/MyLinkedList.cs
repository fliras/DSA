namespace DataStructures
{
    public class MyLinkedList
    {
        public Node? Head { get; set; }

        public void PutAtBeginning(int data)
        {
            Node newNode = new() { Data = data, Next = Head };
            Head = newNode;
        }

        public void PutAtEnd(int data)
        {
            Node newNode = new() { Data = data };

            if (Head == null)
            {
                Head = newNode;
                return;
            }

            Node current = Head;
            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = newNode;
        }

        public static void PutAfter(Node previousNode, int data)
        {
            if (previousNode == null)
            {
                Console.WriteLine("Previous node cannot be null.");
            }
            else
            {
                Node newNode = new() { Data = data, Next = previousNode.Next };
                previousNode.Next = newNode;
            }
        }

        public void DeleteNode(int position)
        {
            if (Head == null) return;
            if (position == 0)
            {
                Head = Head.Next;
                return;
            }

            Node? current = Head;
            for (int i = 0; current != null && i < (position - 1); i++)
            {
                current = current.Next;
            }

            if (current == null || current.Next == null) return;
            current.Next = current.Next.Next;
        }

        public void Print()
        {
            Node? current = Head;
            while (current != null)
            {
                Console.Write($"({current.Data})-->");
                current = current.Next;
            }
            Console.WriteLine();
        }

        public bool Search(int value)
        {
            Node? current = Head;
            while (current != null)
            {
                if (current.Data == value) return true;
                current = current.Next;
            }
            return false;
        }
    }

    public class Node
    {
        public int Data { get; set; }
        public Node? Next { get; set; }
    }
}
