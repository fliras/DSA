namespace DataStructures
{
    public class LinkedListBasedQueue<T>
    {
        private Node<T>? _front = null;
        private Node<T>? _rear = null;

        public bool IsEmpty()
        {
            return _rear == null;
        }

        public void Enqueue(T value)
        {
            Node<T> newNode = new Node<T> { Value = value };
            if (IsEmpty()) _front = _rear = newNode;
            else
            {
                _rear.Next = newNode;
                _rear = _rear.Next;
            }
        }

        public T Dequeue()
        {
            if (IsEmpty()) throw new ArithmeticException("Queue is empty");
            T value = _front.Value;
            if (_front.Next == null) _front = _rear = null;
            else _front = _front.Next;
            return value;
        }

        public T Peek()
        {
            if (IsEmpty()) throw new ArithmeticException("Queue is empty");
            return _front.Value;
        }

        public void Print()
        {
            if (IsEmpty())
            {
                Console.WriteLine("[]");
            }
            else
            {
                Console.Write("[");
                Node<T> current = _front;
                while (current != null)
                {
                    Console.Write($"{current.Value},");
                    current = current.Next;
                }
                Console.WriteLine("]");
            }
        }
    }
}
