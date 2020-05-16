using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice
{
    public class Ques5LongestPalindromic
    {
        public static void longestPalindrome()
        {
            string s = "bb";
            Console.WriteLine(longestPalindrome(s));

        }
        public static String longestPalindrome(String s)
        {
            string maxString = "";
            for (int i = 0; i < s.Length && s.Length > maxString.Length; i++)
            {
                string s1 = expandAroundCenter(s, i, i);
                string s2 = expandAroundCenter(s, i, i + 1);

                if (s1.Length > maxString.Length)
                    maxString = s1;
                if (s2.Length > maxString.Length)
                    maxString = s2;
            }
            return maxString;
        }

        private static string expandAroundCenter(String s, int left, int right)
        {
            int L = left, R = right;
            while (L >= 0 && R < s.Length && s[L] == s[R])
            {
                L--;
                R++;
            }
            // break the previous match 
            return s.Substring(L + 1, R - L - 1);
        }
    }
}
