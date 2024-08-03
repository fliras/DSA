namespace Algorithms
{
    public static class BubbleSort
    {
        public static void Handle(int[] array)
        {
            int length = array.Length;
            for (int i = 0; i < length - 1; i++)
            {
                bool swapped = false;
                for (int j = 0; j < length - i - 1; j++)
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