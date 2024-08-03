namespace DataStructures
{
    public class LinkedListBasedQueue<T>
    {
        private Node<T>? _first = null;
        private Node<T>? _rear = null;

        public bool IsEmpty()
        {
            return _first == null;
        }

        public void Enqueue(T value)
        {
            Node<T> newNode = new (){ Value = value };
            if (_rear == null) _first = _rear = newNode;
            else
            {
                _rear.Next = newNode;
                _rear = newNode;
            }
        }

        public void DeQueue()
        {
            if (IsEmpty()) return;
            _first = _first?.Next;
            if (_first == null) _rear = null;
        }

        public T? Peek()
        {
            if (_first == null) return default;
            return _first.Value;
        }
    }
}
