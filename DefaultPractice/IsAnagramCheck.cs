using System;
using System.Collections.Generic;
using System.Text;

namespace DefaultPractice
{
    class IsAnagramCheck
    {
        public static void IsAnagram()
        {
            string s = "anagram", t = "nagaram";
            //string s = "rat", t = "car";

            Console.WriteLine("is Anagram  :" + IsAnagramBySorting("a", "b"));
        }
        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
                return false;

            int[] tracker = new int[128];

            foreach (var item in s)
            {
                tracker[item]++;
            }

            foreach (var item in t)
            {
                tracker[item]--;
                if (tracker[item] < 0)
                    return false;
            }

            return true;
        }

        public static bool IsAnagramBySorting(string s, string t)
        {
            if (s.Length != t.Length)
                return false;

           // bool result = new string(Array.Sort(s.ToCharArray())) == new string(Array.Sort(t.ToCharArray()));
            return false;
        }
    }
}
