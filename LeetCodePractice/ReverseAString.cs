using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice
{
    public class ReverseAString
    {
        public static void ReverseString()
        {
            char[] s = { 'h', 'e', 'l', 'l', 'o' };
            reverseHelper(s, 0);
        }
        public static void reverseHelper(char[] s, int index)
        {
            if (index == s.Length / 2) return;

            //Swapping this char
            char temp = s[index];
            s[index] = s[s.Length - index];
            s[s.Length - index] = temp;

            reverseHelper(s, index + 1);
        }
    }
}
