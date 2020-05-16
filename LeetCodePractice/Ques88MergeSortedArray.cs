using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice
{
    public class Ques88MergeSortedArray
    {
        public static void Merge()
        {
            int[] nums1 = { 1, 2, 3, 0, 0, 0 };
            int m = 3;
            int[] nums2 = { 2, 5, 6 };
            int n = 3;
            Merge(nums1, m, nums2, n);

            foreach (var item in nums1)
            {
                Console.WriteLine(item);
            }
        }

        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {

            int p1 = m-1;
            int p2 = n-1;
            int i = m + n - 1;
            while (p2 >= 0 && i >= 0)
            {
                if (nums2[p2] >= nums1[p1])
                {
                    nums1[i] = nums2[p2];
                    p2--;
                    i--;
                }
                else
                {
                    nums1[i] = nums1[p1];
                    p1--;
                    i--;
                }
             }


        }
    }
}
