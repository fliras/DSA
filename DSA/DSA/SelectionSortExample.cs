﻿using Algorithms;

namespace DSA
{
    internal static class SelectionSortExample
    {
        static void Main(string[] args)
        {
            int[] array1 = { 5, -1, 4, 3, 92, 78, 78 };
            PrintarArray(array1);
            SelectionSort.Handle(array1);
            PrintarArray(array1);
            Console.WriteLine();

            int[] array2 = { 5, 4, 3, 2, 1, 0, -1, -2 };
            PrintarArray(array2);
            SelectionSort.Handle(array2);
            PrintarArray(array2);
            Console.WriteLine();

            int[] array3 = { 0, 0, 0, -34, 34, 3, 2 };
            PrintarArray(array3);
            SelectionSort.Handle(array3);
            PrintarArray(array3);
            Console.WriteLine();
        }

        static void PrintarArray(int[] array)
        {
            Console.WriteLine(String.Join(",", array));
        }
    }
}
