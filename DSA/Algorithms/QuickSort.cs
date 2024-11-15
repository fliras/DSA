﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class QuickSort
    {
        public static void Handle(int[] array, int low, int high)
        {
            if (low >= high) return;
            int pivotIndex = Partition(array, low, high);
            Handle(array, low, pivotIndex - 1);
            Handle(array, pivotIndex + 1, high);
        }

        public static int Partition(int[] array, int low, int high)
        {
            int pivotValue = array[high];
            int i = low - 1;
            for (int j = low; j < high; j++)
            {
                if (array[j] <= pivotValue)
                {
                    i++;
                    (array[j], array[i]) = (array[i], array[j]);
                }
            }
            (array[i + 1], array[high]) = (array[high], array[i + 1]);
            return i + 1;
        }
    }
}
