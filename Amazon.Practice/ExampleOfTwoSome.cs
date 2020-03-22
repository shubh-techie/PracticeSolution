using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.Practice
{
    class ExampleOfTwoSome
    {


        //Solution 1: using looping all pair of element.
        public static bool TwoSumUsingLoopingAllItems(int[] A, int arr_size, int sum)
        {
            if (arr_size < 0)
                return false;

            bool isFound = false;

            for (int i = 0; i < A.Length; i++)
            {
                for (int j = i + 1; j < A.Length; j++)
                {
                    if (A[i] + A[j] == sum)
                    {
                        isFound = true;
                        break;
                    }
                }
            }

            return isFound;
        }


        //solution 2. using arrary sorting
        public static bool TwoSumUsingSorting(int[] Arr, int arr_size, int sum)
        {
            if (arr_size < 0)
                return false;

            bool isFound = false;

            int leftIndex = 0, rightIndex = arr_size - 1;
            quickSorting(Arr, leftIndex, rightIndex);

            while (leftIndex < rightIndex)
            {
                if (Arr[leftIndex] + Arr[rightIndex] == sum)
                {
                    isFound = true;
                    break;
                }
                else if (Arr[leftIndex] + Arr[rightIndex] < sum)
                {
                    leftIndex++;
                }
                else
                    rightIndex--;
            }

            return isFound;
        }


        //Solution 3 using hashset 
        public static bool TwoSumUsingHashSet(int[] Arr, int arr_size, int sum)
        {
            if (arr_size < 0)
                return false;

            bool isFound = false;
            HashSet<int> TrackingPair = new HashSet<int>();

            for (int i = 0; i < arr_size; i++)
            {
                int otherPair = sum - Arr[i];
                if (TrackingPair.Contains(otherPair))
                {
                    isFound = true;
                    break;
                }
                TrackingPair.Add(otherPair);
            }

            return isFound;
        }

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

            for (j = left; j <= right; j++)
            {
                if (arr[j] <= tempPivotNumber)
                {
                    pivotIndex++;
                    //Swapping the ith and jth element
                    int temp = arr[pivotIndex];
                    arr[pivotIndex] = arr[j];
                    arr[j] = temp;
                }
            }

            return pivotIndex;
        }


        public static int[] TwoSum(int[] nums, int target)
        {
            int[] results = new int[2];
            HashSet<int> TrackD = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {

                //43- 997
                int oPair = target - nums[i];
                if (TrackD.Contains(oPair))
                {
                    results[0] =  GetIndexOfOtherPair(oPair, nums); //TrackD.GetValueOrDefault(oPair); //
                    results[1] = i;
                    break;
                }
                TrackD.Add(nums[i]);
            }
            return results;
        }

        public static int GetIndexOfOtherPair(int oPair, int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == oPair)
                    return i;
            }
            return 0;
        }
    }
}
