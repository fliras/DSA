using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class SelectionSort
    {
        public static void Handle(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int indiceDoMenorElemento = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[indiceDoMenorElemento])
                        indiceDoMenorElemento = j;
                }

                if (indiceDoMenorElemento != i)
                {
                    (array[indiceDoMenorElemento], array[i]) = (array[i], array[indiceDoMenorElemento]);
                }
            }
        }
    }
}
