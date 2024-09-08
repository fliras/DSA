using Algorithms;

namespace DSA
{
    internal static class MergeSortExample
    {
        static void Main(string[] args)
        {
            int[] array1 = { 5, -1, 4, 3, 92, 78, 78 };
            PrintarArray(array1);
            MergeSort.Handle(array1, 0, array1.Length - 1);
            PrintarArray(array1);
            Console.WriteLine();

            int[] array2 = { 5, 4, 3, 2, 1, 0, -1, -2 };
            PrintarArray(array2);
            MergeSort.Handle(array2, 0, array2.Length - 1);
            PrintarArray(array2);
            Console.WriteLine();

            int[] array3 = { 0, 0, 0, -34, 34, 3, 2 };
            PrintarArray(array3);
            MergeSort.Handle(array3, 0, array3.Length - 1);
            PrintarArray(array3);
            Console.WriteLine();
        }

        static void PrintarArray(int[] array)
        {
            Console.WriteLine(String.Join(",", array));
        }
    }
}
