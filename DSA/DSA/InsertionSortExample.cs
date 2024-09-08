using Algorithms;

namespace DSA
{
    internal static class InsertionSortExample
    {
        static void Main(string[] args)
        {
            int[] array1 = { 5, -1, 4, 3, 92, 78, 78 };
            int[] array2 = { 5, 4, 3, 2, 1, 0, -1, -2 };
            int[] array3 = { 0, 0, 0, -34, 34, 3, 2 };

            Console.WriteLine("array 1 desordenado:");
            PrintarArray(array1);
            InsertionSort.Handle(array1);
            Console.WriteLine("array 1: ordenado: ");
            PrintarArray(array1);


            Console.WriteLine("array 2 desordenado:");
            PrintarArray(array2);
            InsertionSort.Handle(array2);
            Console.WriteLine("array 2: ordenado: ");
            PrintarArray(array2);

            Console.WriteLine("array 3 desordenado:");
            PrintarArray(array3);
            InsertionSort.Handle(array3);
            Console.WriteLine("array 3: ordenado: ");
            PrintarArray(array3);

            Console.ReadKey();
        }

        static void PrintarArray(int[] array)
        {
            Console.WriteLine(String.Join(",", array));
        }
    }
}
