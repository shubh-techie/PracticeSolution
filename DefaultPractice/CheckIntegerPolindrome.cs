using System;
using System.Collections.Generic;
using System.Text;

namespace DefaultPractice
{
    public class CheckIntegerPolindrome
    {
        public static void IsPalindrome()
        {
            Console.WriteLine("is polindrome " + IsPalindrome("RACECAR"));
        }
        public static bool IsPalindrome(string str)
        {
            if (str.Length < 1) return true;
            char[] track = new char[128];
            foreach (var item in str)
            {
                track[item]++;
            }
            int odds = 0;
            for (int i = 0; i < track.Length; i++)
            {
                if (track[i] % 2 != 0)
                {
                    odds++;
                }
            }
            return odds < 2;
        }
    }
}
