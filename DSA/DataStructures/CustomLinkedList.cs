namespace DataStructures
{
    public class CustomLinkedList<T>
    {
        public Node<T> Head { get; set; }

        public void InsertAtBeginning(T value)
        {
            Node<T> newNode = new Node<T> { Value = value };
            if (Head == null) Head = newNode;
            else
            {
                newNode.Next = Head;
                Head = newNode;
            }
        }

        public void InsertAtEnding(T value)
        {
            Node<T> newNode = new Node<T> { Value = value };
            if (Head == null) Head = newNode;
            else
            {
                Node<T> current = Head;
                while (current.Next != null)
                    current = current.Next;
                current.Next = newNode;
            }
        }

        public void InsertAt(int index, T value)
        {
            Node<T> newNode = new Node<T> { Value = value };
            if (Head == null) throw new ArithmeticException("Out of range");
            if (index == 0) InsertAtBeginning(value);
            else
            {
                Node<T> current = Head;
                for (int i = 0; current != null && i < index - 1; i++)
                {
                    current = current.Next;
                }
                if (current == null) throw new ArithmeticException("Out of range");
                newNode.Next = current.Next;
                current.Next = newNode;
            }
        }

        public void DeleteFromBeginning()
        {
            if (Head == null) return;
            Head = Head.Next;
        }

        public void DeleteFromEnding()
        {
            if (Head == null) return;
            if (Head.Next == null) Head = null;
            else
            {
                Node<T> current = Head;
                while (current.Next.Next != null)
                {
                    current = current.Next;
                }
                current.Next = current.Next.Next;
            }
        }

        public void DeleteFrom(int index)
        {
            if (Head == null) throw new ArithmeticException("Out of range");
            if (index == 0) DeleteFromBeginning();
            else
            {
                Node<T> current = Head;
                for (int i = 0; current != null && i < (index - 1); i++)
                {
                    current = current.Next;
                }
                if (current == null || current.Next == null) throw new ArithmeticException("Out of range");
                current.Next = current.Next.Next;
            }
        }

        public int Search(T value)
        {
            if (Head == null) throw new ArithmeticException("List is empty");
            Node<T> current = Head;
            int index = 0;
            while (current != null)
            {
                if (current.Value.Equals(value)) return index;
                current = current.Next;
                index++;
            }
            return -1;
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
    }

    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Next { get; set; }
    }
}
