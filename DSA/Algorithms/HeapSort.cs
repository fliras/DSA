namespace Algorithms
{
    public static class HeapSort
    {
        public static void Handle(int[] array)
        {
            for (int i = array.Length / 2 - 1; i >= 0; i--)
            {
                Heapify(array, array.Length, i);
            }

            for (int i = array.Length - 1; i >= 0; i--)
            {
                (array[0], array[i]) = (array[i], array[0]);
                Heapify(array, i, 0);
            }
        }

        public static void Heapify(int[] array, int length, int root)
        {
            int largest = root;
            int left = 2 * root + 1;
            int right = 2 * root + 2;

            if (left < length && array[left] > array[largest])
                largest = left;

            if (right < length && array[right] > array[largest])
                largest = right;

            if (largest != root)
            {
                (array[largest], array[root]) = (array[root], array[largest]);
                Heapify(array, length, largest);
            }
        }
    }
}
