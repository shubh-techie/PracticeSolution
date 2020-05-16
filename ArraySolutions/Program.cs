using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySolutions
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] candidates = { 2, 3, 6, 7 };
            int target = 7;
            var coll = CombinationSum(candidates, target);
            foreach (var item in coll)
            {
                foreach (var result in item)
                {
                    Console.Write(result);
                }
                Console.WriteLine();
            }

            //SumOfFour();
            //LengthOfLongestSubstring("abcabcbb");
            //Console.WriteLine(MyAtoi("    -42  "));
            //int[] arr = { 3, 2, 4 };
            //int[] result = TwoSum(arr, 6);
            //Console.WriteLine(string.Join(",", result));
            ////WindowSlidingSolution.WindowSlidingDemo();
            //BuySellStocksSolution.maxProfit();
            ////WaterTrappingSolution.trappingWaterdemo();
            ////RotateArrayDemo.rotateDemo();



            Console.WriteLine("Press <enter> to exit");
            Console.ReadLine();
        }

        public int SubarraySum(int[] nums, int k)
        {

            int count = 0, sum = 0;

            Dictionary<int, int> map = new Dictionary<int, int>();
            map.Add(0, 1);
            for (int i = 0; i < nums.Length; i++)
            {
                sum = sum + nums[i];
                int otherPair = sum - k;
                if (map.ContainsKey(otherPair))
                {
                    count += map[otherPair];
                }
                map.Add(sum, map.SingleOrDefault(sum, 0) + 1);
            }

            return count;
        }

        public static IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            IList<IList<int>> output = new List<IList<int>>();
            Array.Sort(candidates);
            helper(output, new List<int>(), candidates, target, candidates.Length);
            return output;
        }
        public static void helper(IList<IList<int>> output, IList<int> curr, int[] candidates, int target, int index)
        {
            if (index == 0) return;

            if (target == 0)
            {
                output.Add(curr);
                Console.WriteLine(string.Join(",", curr));
                Console.WriteLine("inside return function");
                return;
            }

            if (target >= candidates[index - 1])
            {
                curr.Add(candidates[index - 1]);
                helper(output, curr, candidates, target - candidates[index - 1], index);
                curr.Remove(curr.Count - 1);
            }

            helper(output, curr, candidates, target, index - 1);

        }
        private static void SumOfFour()
        {
            int[] nums = { 1, 0, -1, 0, -2, 2 };
            IList<IList<int>> output = FourSum(nums, 0);
        }

        public static IList<IList<int>> FourSum(int[] nums, int target)
        {
            IList<IList<int>> output = new List<IList<int>>();
            Dictionary<int, int[]> track = new Dictionary<int, int[]>();
            HashSet<string> seen = new HashSet<string>();
            int n = nums.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    int sum = nums[i] + nums[j];
                    int oPairSum = target - sum;
                    if (track.ContainsKey(oPairSum))
                    {
                        int[] pair = track[oPairSum];
                        if (pair[0] == i || pair[1] == j || pair[0] == i || pair[1] == j) continue;
                        else
                        {
                            List<int> makeKey = new List<int>() { i, j, pair[0], pair[1] };
                            makeKey.Sort();
                            string key = string.Join(",", makeKey);
                            if (seen.Contains(key))
                            {
                                IList<int> temp = new List<int>() { nums[i], nums[j], nums[pair[0]], nums[pair[1]] };
                                output.Add(temp);
                            }
                            else
                            {
                                seen.Add(key);
                            }
                        }
                    }
                    else if (!track.ContainsKey(sum))
                    {
                        track.Add(sum, new int[2] { i, j });
                    }
                }
            }

            return output;

        }
        public string ReverseVowels(string s)
        {
            int left = 0, right = s.Length - 1;
            HashSet<char> vo = new HashSet<char>() { 'a', 'e', 'i', 'o', 'u' };
            char[] str = s.ToCharArray();

            while (left < right)
            {
                if (vo.Contains(str[left]) && vo.Contains(str[right]))
                {
                    char ch = s[left];
                    str[left] = s[right];
                    str[right] = ch;
                }
                else if (vo.Contains(s[left]))
                {
                    right--;
                }
                else
                {
                    left++;
                }
            }
            return new string(str);
        }

        public static int LengthOfLongestSubstring(string s)
        {
            int i = 0, j = 0, size = s.Length, uMax = 0;
            HashSet<char> track = new HashSet<char>();


            while (i < size && j < size)
            {
                Console.WriteLine(string.Join(",", track));
                if (!track.Contains(s[j]))
                {
                    track.Add(s[j]);
                    j++;
                    uMax = Math.Max(uMax, j - i);
                }
                else
                {
                    track.Remove(s[i]);
                    i++;
                }
            }


            return uMax;
        }

        public static int MyAtoi(string str)
        {
            str = str.Trim();
            if (str == null || str.Length == 0) return 0;

            long result = 0;
            int indicator = 1;
            int i = 0;

            if (str[0] == '+')
            {
                indicator = 1; i++;
            }
            else if (str[0] == '-')
            {
                indicator = -1; i++;
            }


            while (i < str.Length && char.IsDigit(str[i]))
            {
                result = result * 10 + (str[i] - '0');
                if (result * indicator >= int.MaxValue) return int.MaxValue;
                if (result * indicator <= int.MinValue) return int.MinValue;
                i++;
            }

            return (int)result * indicator;

        }


        public static int[] TwoSum(int[] nums, int target)
        {
            return SumOfTwoUsingBS(nums, target, 0, nums.Length - 1);
        }

        public static int[] SumOfTwoUsingBS(int[] nums, int target, int left, int right)
        {
            int[] result = new int[2];
            Array.Sort(nums);

            while (left < right)
            {
                int mid = (left + right) / 2;
                int cSum = nums[left] + nums[right];
                if (cSum == target)
                {
                    result[0] = left;
                    result[1] = right;
                    break;
                }
                else if (cSum < target)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            return result;
        }

        public int[] intersection(int[] nums1, int[] nums2)
        {
            HashSet<int> set = new HashSet<int>();
            HashSet<int> intersect = new HashSet<int>();
            foreach (var item in nums1)
            {
                set.Add(item);
            }

            foreach (var item in nums1)
            {
                if (set.Contains(item))
                {
                    intersect.Add(item);
                }
            }

            int[] result = new int[intersect.Count];
            int i = 0;
            foreach (var num in intersect)
            {
                result[i++] = num;
            }
            return result;
        }


    }
}
