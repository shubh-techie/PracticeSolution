using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice
{
    public class Ques186ReverseWords
    {
        public static void ReverseWords()
        {
            string[] input = { "t", "h", "e", " ", "s", "k", "y", " ", "i", "s", " ", "b", "l", "u", "e" };
            Array.Reverse(input);

            foreach (var item in input)
            {
                Console.Write(item + ",");
            }

            // return reversedArray;
        }

        public void reverseEachWord(string[] s)
        {
            int n = s.Length;
            int start = 0, end = 0;

            while (start < n)
            {
                // go to the end of the word
                while (end < n && s[end] != " ") ++end;
                // reverse the word
                //reverse(s, start, end - 1);
                // move to the next word
                start = end + 1;
                ++end;
            }
        }

    }
}
