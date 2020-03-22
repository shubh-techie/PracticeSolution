using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.Practice
{
    class InsertionSort
    {
        public static void insertionSort(int[] Arr)
        {
            int length = Arr.Length;
            int i = 0, j = 0, temp;

            for (i = 1; i < length; i++)
            {
                temp = Arr[i];
                j = i;

                while (j > 0 && Arr[j - 1] > temp)
                {
                    Arr[j] = Arr[j - 1];
                    j--;
                }
                Arr[j] = temp;
            }

        }
    }
}
