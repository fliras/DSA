namespace DataStructures
{
    public class CustomLinkedList<T>
    {
        public Node<T> Head { get; set; }

        public void InsertAtBeginning(T value)
        {
            Node<T> newNode = new Node<T> { Value = value };
            if (Head == null)
            {
                Head = newNode;
                return;
            }
            newNode.Next = Head;
            Head = newNode;
        }

        public void InsertAtEnd(T value)
        {
            Node<T> newNode = new Node<T> { Value = value };
            if (Head == null)
            {
                Head = newNode;
                return;
            }
            Node<T> current = Head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }

        public void InsertAt(int position, T value)
        {
            if (position == 0)
            {
                InsertAtBeginning(value);
                return;
            }
            if (Head == null) return;
            Node<T> current = Head;
            for (int i = 0; current != null && i < (position - 1); i++)
            {
                current = current.Next;
            }
            if (current == null) return;
            Node<T> newNode = new Node<T> { Value = value, Next = current.Next };
            current.Next = newNode;
        }

        public void DeleteFromBeginning()
        {
            if (Head == null) return;
            Head = Head.Next;
        }

        public void DeleteFromEnd()
        {
            if (Head == null) return;
            if (Head.Next == null)
            {
                Head = Head.Next;
                return;
            }
            Node<T> current = Head;
            while (current.Next.Next != null)
            {
                current = current.Next;
            }
            current.Next = null;
        }

        public void DeleteAt(int position)
        {
            if (position == 0)
            {
                DeleteFromBeginning();
                return;
            }
            if (Head == null) return;
            Node<T> current = Head;
            for (int i = 0; current != null && i < (position - 1); i++)
            {
                current = current.Next;
            }
            if (current == null || current.Next == null) return;
            current.Next = current.Next.Next;
        }

        public void Print()
        {
            if (Head == null) return;
            Node<T> current = Head;
            while (current != null)
            {
                Console.Write($"({current.Value})->");
                current = current.Next;
            }
            Console.WriteLine();
        }

        public int Search(T value)
        {
            if (Head == null) return -1;
            Node<T> current = Head;
            int position = 0;
            while (current != null && !current.Value.Equals(value))
            {
                current = current.Next;
                position++;
            }
            if (current == null) return -1;
            return position;
        }
    }

    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Next { get; set; }
    }
}
