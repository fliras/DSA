using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class BinarySearch
    {
        public static int Handle(int[] array, int element)
        {
            int start = 0;
            int end = array.Length - 1;
            while (start <= end)
            {
                int middle = (start + end) / 2;
                if (array[middle] == element)
                    return middle;
                else if (array[middle] < element)
                    start = middle + 1;
                else
                    end = middle - 1;
            }
            return -1;
        }
    }
}
