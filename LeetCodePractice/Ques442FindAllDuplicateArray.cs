using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice
{
    /*
        442. Find All Duplicates in an Array
        Given an array of integers, 1 ≤ a[i] ≤ n (n = size of array), some elements appear twice and others appear once.

        Find all the elements that appear twice in this array.

        Could you do it without extra space and in O(n) runtime?

        Example:
        Input:
        [4,3,2,7,8,2,3,1]

        Output:
        [2,3]
     */
    public class Ques442FindAllDuplicateArray
    {
        public static void FindDuplicates()
        {
            int[] nums = { 4, 3, 2, 7, 8, 2, 3, 1 };
            IList<int> output = FindDuplicatesNoSpace(nums);

            foreach (var item in output)
            {
                Console.WriteLine(item);
            }
        }

        public static IList<int> FindDuplicatesNoSpace(int[] nums)
        {
            IList<int> result = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int index = Math.Abs(nums[i]) - 1;
                if (nums[index] < 0)
                    result.Add(Math.Abs(index + 1));
                nums[index] = -nums[index];
            }

            return result;
        }
        public static IList<int> FindDuplicates(int[] nums)
        {
            HashSet<int> output = new HashSet<int>();
            IList<int> result = new List<int>();
            foreach (var item in nums)
            {
                if (output.Contains(item))
                {
                    result.Add(item);
                }
                else
                {
                    output.Add(item);
                }
            }

            return result;
        }
    }
}
