using Algorithms;

namespace DSA
{
    internal static class BubbleSortExample
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[] { 5, -1, 4, 3, 92, 78, 78 };
            PrintArray(array1);
            BubbleSort.Handle(array1);
            PrintArray(array1);
            Console.WriteLine();

            int[] array2 = new int[] { 5, 4, 3, 2, 1, 0, -1, -2 };
            PrintArray(array2);
            BubbleSort.Handle(array2);
            PrintArray(array2);
            Console.WriteLine();

            int[] array3 = new int[] { 0, 0, 0, -34, 34, 3, 2 };
            PrintArray(array3);
            BubbleSort.Handle(array3);
            PrintArray(array3);
            Console.WriteLine();

            Console.ReadKey();
        }

        static void PrintArray(int[] array)
        {
            Console.WriteLine(String.Join(",", array));
        }
    }
}
