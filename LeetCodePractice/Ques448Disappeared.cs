using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice
{
    class Ques448Disappeared
    {
        public static void FindDisappearedNumbers()
        {
            int[] nums = {1,1};
            IList<int> output = FindDisappearedNumbers(nums);
            foreach (var item in output)
            {
                Console.WriteLine(item);
            }
        }
        public static IList<int> FindDisappearedNumbers(int[] nums)
        {
            HashSet<int> tracker = new HashSet<int>();

            IList<int> output = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                tracker.Add(nums[i]);
            }

            for (int i = 1; i <= nums.Length; i++)
            {
                if (!tracker.Contains(i))
                {
                    output.Add(i);
                }
            }

            return output;
        }
    }
}
