namespace DataStructures
{
    public class CustomArrayBasedQueue<T>(int length)
    {
        private readonly T[] _array = new T[length];
        private int _front = -1;
        private int _rear = -1;

        public void Enqueue(T value)
        {
            if (IsFull()) return;
            if (_front == -1) _front++;
            _array[++_rear] = value;
        }

        public void DeQueue()
        {
            if (IsEmpty()) return;
            if (_front == _rear) _front = _rear = -1;
            else _front++;
        }

        public T? Peek()
        {
            if (IsEmpty()) return default;
            return _array[_front];
        }

        public bool IsEmpty()
        {
            return _rear == -1;
        }

        public bool IsFull()
        {
            return _rear == _array.Length - 1;
        }
    }
}
