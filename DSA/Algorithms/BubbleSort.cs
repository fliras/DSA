namespace Algorithms
{
    public static class BubbleSort
    {
        public static void Handle(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                bool swapped = false;
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        swapped = true;
                        (array[j], array[j + 1]) = (array[j + 1], array[j]);
                    }
                }
                if (!swapped) break;
            }
        }
    }
}