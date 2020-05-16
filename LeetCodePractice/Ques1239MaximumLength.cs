using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice
{
    public class Ques1239MaximumLength
    {
        public static void readAllCombination()
        {
            IList<string> arr = new List<string>() { "A", "B", "C" };
            string output = readAllCombinationHelper(arr, 0, "");
        }

        private static string readAllCombinationHelper(IList<string> arr, int index, string all)
        {
            if (index > arr.Count)
                return all;
            for (int i = index; i < arr.Count; i++)
            {
                all = all + arr[index];
                all = readAllCombinationHelper(arr, index + 1, all);
            }
            Console.WriteLine("i={1}, index= {0}, all=  : {2}", 0, 0, all);
            return all;
        }

        public static void MaxLength()
        {
            IList<string> arr = new List<string>() { "cha", "r", "act", "ers" };
            Console.WriteLine(MaxLength(arr));

        }
        public static int MaxLength(IList<string> arr)
        {
            string lMax = "", uMax = "";
            uMax = CheckUnique(arr, 0, lMax, "");
            return uMax.Length;
        }
        public static string CheckUnique(IList<string> arr, int index, string lMax, string uMax)
        {
            if (!IsUnique(lMax) || index > arr.Count)
            {
                return uMax;
            }

            if (lMax.Length > uMax.Length)
                uMax = lMax;

            for (int i = index; i < arr.Count; i++)
            {
                uMax = CheckUnique(arr, i + 1, lMax + arr[i], uMax);
            }

            return uMax;
        }

        public static bool IsUnique(string str)
        {
            HashSet<char> unique = new HashSet<char>();
            foreach (char ch in str)
            {
                if (unique.Contains(ch))
                {
                    return false;
                }
                else
                {
                    unique.Add(ch);
                }
            }

            return true;
        }
    }
}
