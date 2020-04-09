using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.Practice
{
    public class QuickSort
    {
        public static void quickSorting(int[] Arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = getPivotOfArray(Arr, left, right);
                quickSorting(Arr, left, pivot - 1);
                quickSorting(Arr, pivot + 1, right);
            }
        }

        private static int getPivotOfArray(int[] arr, int left, int right)
        {
            int tempPivotNumber = arr[right];
            int pivotIndex, j;
            pivotIndex = left - 1;

            pintArrayRec(arr);
            Console.WriteLine("-------------------------------");
            for (j = left; j <= right; j++)
            {
                if (arr[j] <= tempPivotNumber)
                {
                    pivotIndex++;
                    int temp = arr[pivotIndex];
                    arr[pivotIndex] = arr[j];
                    arr[j] = temp;
                }

                Console.WriteLine("index :{0}, pivot :{1}", j, pivotIndex);
            }
            pintArrayRec(arr);
            return pivotIndex;
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
            if (arr[index] != 0)
                Console.Write(arr[index] + " ");
            helerRec(arr, index + 1);
        }
    }
}
