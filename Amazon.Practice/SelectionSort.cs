using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.Practice
{
    class SelectionSort
    {
        public static void selectionSort(int[] Arr, int Size)
        {
            for (int i = 0; i < Size; i++)
            {
                int MixIndex = i;
                for (int j = i; j < Size; j++)
                {
                    if (Arr[j] <= Arr[MixIndex])
                    {
                        MixIndex = j;
                    }
                }

                int temp = Arr[i];
                Arr[i] = Arr[MixIndex];
                Arr[MixIndex] = temp;
            }
        }


    }
}
