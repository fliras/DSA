using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class ArrayBasedStack<T>(int length)
    {
        private readonly T[] _array = new T[length];
        private int _top = -1;

        public bool IsEmpty()
        {
            return _top == 0;
        }

        public bool IsFull()
        {
            return _top == length - 1;
        }

        public void Push(T value)
        {
            if (IsFull()) return;
            _array[++_top] = value;
        }

        public T? Pop()
        {
            if (IsEmpty()) return default;
            return _array[_top--];
        }

        public T? Peek()
        {
            if (IsEmpty()) return default;
            return _array[_top];
        }

        public void Print()
        {
            Console.WriteLine("--");
            for (int i = _top; i >= 0; i--)
            {
                Console.WriteLine(_array[i]);
            }
            Console.WriteLine("--");
        }
    }
}
