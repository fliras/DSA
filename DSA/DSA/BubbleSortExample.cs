using Algorithms;

namespace DSA
{
    internal static class BubbleSortExample
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 2, -1, 4, 3, 98, 100, 0, 666, -666, 319, 475, 89, 69, 666, -666 };
            Console.WriteLine(String.Join(",", array));

            BubbleSort.Handle(array);
            Console.WriteLine(String.Join(",", array));

            Console.ReadKey();
        }
    }
}
