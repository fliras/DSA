﻿using DataStructures;

namespace DSA
{
    internal static class StackExample
    {
        static void Mainha(string[] args)
        {
            CustomStack<int> stack = new CustomStack<int>(5);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Print();
            Console.WriteLine();

            stack.Push(30);
            stack.Print();
            Console.WriteLine();

            int last = stack.Pop();
            Console.WriteLine(last);
            stack.Print();
            Console.WriteLine();

            last = stack.Peek();
            Console.WriteLine(last);
            stack.Print();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
