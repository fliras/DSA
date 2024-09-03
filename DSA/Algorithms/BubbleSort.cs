namespace Algorithms
{
    public static class BubbleSort
    {
        public static void Handle(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                bool swapped = false;
                for (int j = 0; j < array.Length - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        (array[j], array[j + 1]) = (array[j + 1], array[j]);
                        swapped = true;
                    }
                }
                if (!swapped) break;
            }
        }
    }
}