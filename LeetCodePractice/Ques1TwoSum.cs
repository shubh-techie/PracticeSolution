using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice
{
    /*
        Given an array of integers, return indices of the two numbers such that they add up to a specific target.

        You may assume that each input would have exactly one solution, and you may not use the same element twice.

        Example:

        Given nums = [2, 7, 11, 15], target = 9,

        Because nums[0] + nums[1] = 2 + 7 = 9,
        return [0, 1].
     */
    public class Ques1TwoSum
    {
        public static void TwoSum()
        {
            int[] nums = { 2, 7, 11, 15 };
            int[] output = TwoSum(nums, 9);
        }
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[2];
            Dictionary<int, int> tracker = new Dictionary<int, int>();
            for (int index = 0; index < nums.Length; index++)
            {
                int otherPair = target - nums[index];
                if (tracker.ContainsKey(otherPair))
                {
                    result[0] = tracker[otherPair];
                    result[1] = index;
                    break;
                }
                else
                {
                    tracker.Add(nums[index], index);
                }

            }

            return result;
        }
    }
}
