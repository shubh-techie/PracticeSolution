using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.Practice
{
    public class SearchingDemo
    {
        public static int BinarySearch(int[] arr, int key)
        {
            int left = 0, right = arr.Length - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (key < arr[mid])
                {
                    right = mid - 1;
                }
                else if (key > arr[mid])
                {
                    left = mid + 1;
                }
                else
                {
                    return mid;
                }
            }

            return -1;
        }

        public static int BinarySearchRecursive(int[] arr, int left, int right, int key)
        {
            if (left > right)
            {
                return -1;
            }
            else
            {
                int mid = (left + right) / 2;
                if (key > arr[mid])
                    return BinarySearchRecursive(arr, mid + 1, right, key);
                else if (key < arr[mid])
                    return BinarySearchRecursive(arr, left, mid - 1, key);
                else
                    return mid;
            }

        }
    }
}
