using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.Practice
{
    public class SortingABinaryArray
    {
        public static void sortBinaryArray(int[] a, int n)
        {
            int j = -1;
            for (int i = 0; i < n; i++)
            {
                if (a[i] < 1)
                {
                    j++;
                    int temp = a[j];
                    a[j] = a[i];
                    a[i] = temp;
                }
            }
        }

        private static void pintArrayRec(int[] arr)
        {
            helerRec(arr, 0);
        }

        private static void helerRec(int[] arr, int index)
        {
            if (index >= arr.Length)
            {
                return;
            }
            Console.Write(arr[index] + " ");
            helerRec(arr, index + 1);
        }
    }
}
