namespace Algorithms
{
    public static class MergeSort
    {
        public static void Handle(int[] array, int leftIndex, int rightIndex)
        {
            if (leftIndex < rightIndex)
            {
                int middleIndex = leftIndex + (rightIndex - leftIndex) / 2;
                Handle(array, leftIndex, middleIndex);
                Handle(array, (middleIndex + 1), rightIndex);
                MergeSortedPartsOfTheArray(array, leftIndex, middleIndex, rightIndex);
            }
        }

        public static void MergeSortedPartsOfTheArray(int[] array, int leftIndex, int middleIndex, int rightIndex)
        {
            int sizeOfLeftArray = (middleIndex - leftIndex) + 1;
            int[] leftArray = new int[sizeOfLeftArray];

            int sizeOfRightArray = rightIndex - middleIndex;
            int[] rightArray = new int[sizeOfRightArray];

            int i, j;

            for (i = 0; i < sizeOfLeftArray; i++)
            {
                leftArray[i] = array[leftIndex + i];
            }

            for (j = 0; j < sizeOfRightArray; j++)
            {
                rightArray[j] = array[(middleIndex + 1) + j];
            }

            i = j = 0;
            int k = leftIndex;
            while (i < sizeOfLeftArray && j < sizeOfRightArray)
            {
                if (leftArray[i] <= rightArray[j])
                {
                    array[k++] = leftArray[i++];
                }
                else
                {
                    array[k++] = rightArray[j++];
                }
            }

            while (i < sizeOfLeftArray)
            {
                array[k++] = leftArray[i++];
            }

            while (j < sizeOfRightArray)
            {
                array[k++] = rightArray[j++];
            }
        }
    }
}
