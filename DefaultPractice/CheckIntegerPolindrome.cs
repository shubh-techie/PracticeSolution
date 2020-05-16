using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace DefaultPractice
{
    public class CheckIntegerPolindrome
    {
        public static void IsPalindrome()
        {
            Console.WriteLine("is polindrome " + IsPalindrome(-123));

        }
    

        public string solve(string A)
        {
            string[] arr = A.Trim().Split(' ');
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < arr.Length; i++)
            {
                Array.Reverse(arr[i].ToCharArray());
                sb.Append(new string(arr[i]));
            }

            return sb.ToString();
        }

        public static string RemoveSpecialCharacters(string str)
        {
            return Regex.Replace(str, "[^a-zA-Z0-9_.]+", "", RegexOptions.Compiled).ToLower();
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

        public static bool IsPalindrome(int x)
        {
            if (x < 0 || (x != 0 && x % 10 == 0)) return false;
            int reverse = 0;
            while (x > reverse)
            {
                reverse = reverse * 10 + x % 10;
                x /= 10;
            }

            return x == reverse || x == reverse / 10;
        }
    }
}
