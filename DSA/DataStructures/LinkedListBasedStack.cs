using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class LinkedListBasedStack<T>
    {
        private Node<T> _top;

        public bool IsEmpty()
        {
            return _top == null;
        }

        public void Push(T value)
        {
            Node<T> newNode = new Node<T> { Value = value, Next = _top };
            _top = newNode;
        }

        public T? Peek()
        {
            if (IsEmpty()) return default;
            return _top.Value;
        }

        public T? Pop()
        {
            if (_top == null) return default;
            T topValue = _top.Value;
            _top = _top.Next;
            return topValue;
        }
    }
}
