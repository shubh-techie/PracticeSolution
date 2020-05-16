using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice
{
    class Quest17LetterCombinationsPhone
    {
        public static IList<string> LetterCombinations(string digits)
        {
            if (digits == null || digits.Length == 0)
            {
                return null;
            }

            Dictionary<int, string> phone = new Dictionary<int, string>();
            phone.Add(2, "abc");
            phone.Add(3, "def");
            phone.Add(4, "ghi");
            phone.Add(5, "jkl");
            phone.Add(6, "mno");
            phone.Add(7, "pqrs");
            phone.Add(8, "tuv");
            phone.Add(9, "wxyz");

            IList<string> output = new List<String>();

            recurseHelper(digits, output, phone, 0, "");

            return output;
        }
        public static void recurseHelper(string digits, IList<string> output, Dictionary<int, string> phone, int index, string temp)
        {
            if (index == digits.Length)
            {
                output.Add(temp);
            }
            else
            {
                int phoneDigit = Convert.ToInt32(digits[index].ToString());
                string chars = phone[phoneDigit];
                for (int i = 0; i < chars.Length; i++)
                {
                    recurseHelper(digits, output, phone, index + 1, temp + chars[i].ToString());
                }
            }
        }
    }
}
