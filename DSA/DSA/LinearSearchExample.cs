using Algorithms;

namespace DSA
{
    internal static class LinearSearch
    {
        static void Mainha(string[] args)
        {
            int[] array = { -2, -1, 0, 1, 2, 3, 4 };
            int elemento1 = BinarySearch.Handle(array, 1);
            int elemento2 = BinarySearch.Handle(array, 2);
            int elemento5 = BinarySearch.Handle(array, 5);

            Console.WriteLine("1: " + elemento1); // 3
            Console.WriteLine("2: " + elemento2); // 4
            Console.WriteLine("5: " + elemento5); // -1

            Console.ReadKey();
        }
    }
}
