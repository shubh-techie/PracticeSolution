using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.Practice
{
    public class MergerSortDemo
    {
        public static void Mergersort(int[] A, int size)
        {

            if (size < 2)
            {
                return;
            }

            int mid = size / 2;

            PrintAnArray(A);

            int[] leftArr = new int[mid];
            int[] rightArr = new int[size - mid];

            for (int i = 0; i < mid; i++)
            {
                leftArr[i] = A[i];
            }
            PrintAnArray(leftArr);

            for (int i = mid; i < size; i++)
            {
                rightArr[i - mid] = A[i];
            }

            PrintAnArray(rightArr);

            Mergersort(leftArr, mid);
            Mergersort(rightArr, size - mid);
            MergerLeftAndRightArray(A, leftArr, rightArr);
        }

        public static void PrintAnArray(int[] Arr)
        {
            for (int i = 0; i < Arr.Length; i++)
            {
                Console.Write(Arr[i] + " ");
            }

            Console.WriteLine("");
        }

        private static void MergerLeftAndRightArray(int[] arr, int[] leftArr, int[] rightArr)
        {
            int i = 0, j = 0, k = 0;

            while (i < leftArr.Length && j < rightArr.Length)
            {
                if (leftArr[i] <= rightArr[j])
                {
                    arr[k] = leftArr[i]; i++;
                }
                else
                {
                    arr[k] = rightArr[j]; j++;
                }
                k++;
            }

            while (i < leftArr.Length)
            {
                arr[k] = leftArr[i]; i++; k++;
            }
            while (j < rightArr.Length)
            {
                arr[k] = rightArr[j]; j++; k++;
            }
        }
    }
}
