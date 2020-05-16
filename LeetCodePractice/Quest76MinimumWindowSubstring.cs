using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice
{
    public class Quest76MinimumWindowSubstring
    {
        public static void MinWindow()
        {
            string S = "ADOBECODEBANC", T = "ABC";
            string output = MinWindow(S, T);
            Console.WriteLine(output);
        }
        public static string MinWindow(string s, string t)
        {
            var dict = new Dictionary<char, int>();
            for (int i = 0; i < t.Length; i++)
            {
                if (dict.ContainsKey(t[i]))
                {
                    dict[t[i]]++;
                }
                else
                {
                    dict.Add(t[i], 1);
                }
            }

            var res = string.Empty;
            var len = s.Length + 1;
            var start = 0;
            var count = t.Length;
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine("for i={0} , ch={1}", i, s[i]);
                if (dict.ContainsKey(s[i]))
                {
                    if (dict[s[i]] > 0)
                    {
                         count--;
                    }
                    dict[s[i]]--;
                }

                while (count == 0)
                {
                    if (len > i - start + 1)
                    {
                        len = i - start + 1;
                        res = s.Substring(start, len);
                    }
                    if (dict.ContainsKey(s[start]))
                    {
                        
                        if (dict[s[start]] >= 0)
                        {
                            count++;
                        }
                        dict[s[start]]++;
                    }

                    start++;
                }
            }

            return res;
        }
    }
}
