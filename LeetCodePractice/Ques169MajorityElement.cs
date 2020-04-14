using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice
{
    class Ques169MajorityElement
    {
        public static void MajorityElement()
        {
            int[] nums = { 2147483647 };
            Console.WriteLine(MajorityElement(nums));
        }
        public static int MajorityElement(int[] nums)
        {
            if (nums.Length == 0) return 0;
            if (nums.Length == 1) return 1;
            Dictionary<int, int> Track = new Dictionary<int, int>();

            int maxNumber = 0, maxKey = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (Track.ContainsKey(nums[i]))
                {
                    Track[nums[i]]++;
                    if (Track[nums[i]] > maxKey)
                    {
                        maxNumber = nums[i];
                        maxKey = Track[nums[i]];
                    }
                }
                else
                {
                    Track.Add(nums[i], 1);
                    if (Track[nums[i]] > maxKey)
                    {
                        maxNumber = nums[i];
                        maxKey = Track[nums[i]];
                    }
                }
            }

            return maxNumber;
        }
    }

}
