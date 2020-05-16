using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice
{
    public class Quest4MedianOfTwo
    {
        public void FindMedianSortedArrays()
        {
            int[] nums1 = { 1 ,2};
            int[] nums2 = { 3, 4 ,6};
            double output = findMedianSortedArrays(nums1, nums2);
            Console.WriteLine(output);
        }

        double findMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int N1 = nums1.Length;
            int N2 = nums2.Length;
            if (N1 < N2) return findMedianSortedArrays(nums2, nums1);   // Make sure A2 is the shorter one.

            int lo = 0, hi = N2 * 2;
            while (lo <= hi)
            {
                int mid2 = (lo + hi) / 2;   // Try Cut 2 
                int mid1 = N1 + N2 - mid2;  // Calculate Cut 1 accordingly

                double L1 = (mid1 == 0) ? int.MinValue : nums1[(mid1 - 1) / 2];  // Get L1, R1, L2, R2 respectively
                double L2 = (mid2 == 0) ? int.MinValue : nums2[(mid2 - 1) / 2];
                double R1 = (mid1 == N1 * 2) ? int.MaxValue : nums1[(mid1) / 2];
                double R2 = (mid2 == N2 * 2) ? int.MaxValue : nums2[(mid2) / 2];

                if (L1 > R2) lo = mid2 + 1;     // A1's lower half is too big; need to move C1 left (C2 right)
                else if (L2 > R1) hi = mid2 - 1;    // A2's lower half too big; need to move C2 left.
                else return (Math.Max(L1, L2) + Math.Min(R1, R2)) / 2;    // Otherwise, that's the right cut.
            }
            return -1;
        }
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            if (nums1.Length == 0) return GetMedian(nums2);
            if (nums2.Length == 0) return GetMedian(nums1);

            int[] mergedArray = MergedSortedArrays(nums1, nums2);
            Console.Write(mergedArray.Length);
            return GetMedian(mergedArray);
        }
        public int[] MergedSortedArrays(int[] nums1, int[] nums2)
        {
            int m = nums1.Length;
            int n = nums2.Length;
            int[] output = new int[m + n];
            int i = 0, j = 0, k = 0;
            while (i < m && j < n)
            {
                if (nums1[i] <= nums2[j])
                {
                    output[k] = nums1[i];
                    i++;
                }
                else
                {
                    output[k] = nums2[j];
                    j++;
                }
                k++;
            }

            while (i < m)
            {
                output[k] = nums1[i];
                i++; k++;
            }
            while (j < n)
            {
                output[k] = nums2[j];
                j++; k++;
            }

            return output;
        }
        public double GetMedian(int[] A)
        {
            int size = A.Length;
            if (size % 2 == 0)
            {
                int half = size / 2;
                int sum = A[half] + A[half - 1];
                double output = sum / 2.0;
                return output;
            }
            else
            {
                return A[size / 2];
            }
        }
    }
}
