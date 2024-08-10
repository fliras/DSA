namespace DataStructures
{
    public class CustomArrayBasedQueue<T>(int length)
    {
        private int _front = -1;
        private int _rear = -1;
        private readonly T[] _array = new T[length];

        public bool IsEmpty()
        {
            return _rear == -1;
        }

        public bool IsFull()
        {
            return _rear == _array.Length - 1;
        }

        public void Enqueue(T value)
        {
            if (IsFull()) throw new ArithmeticException("Queue is full");
            if (IsEmpty()) _front++;
            _array[++_rear] = value;
        }

        public T Dequeue()
        {
            if (IsEmpty()) throw new ArithmeticException("Queue is empty");
            T value = Peek();
            if (_front == _rear) _front = _rear = -1;
            else _front++;
            return value;
        }

        public T Peek()
        {
            if (IsEmpty()) throw new ArithmeticException("Queue is empty");
            return _array[_front];
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
                for (int i = _front; i <= _rear; i++)
                    Console.Write($"{_array[i]},");
                Console.WriteLine("]");
            }
        }
    }
}
