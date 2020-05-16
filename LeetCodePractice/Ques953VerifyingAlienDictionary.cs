using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice
{
    public class Ques953VerifyingAlienDictionary
    {
        public static void IsAlienSorted()
        {

            //string[] words = { "hello", "leetcode" };
            //string order = "hlabcdefgijkmnopqrstuvwxyz";
            string[] words = { "kuvp", "q" };
            string order = "ngxlkthsjuoqcpavbfdermiywz";
            Console.WriteLine(IsAlienSorted(words, order));

        }
        public static bool IsAlienSorted(string[] words, string order)
        {
            if (words.Length <= 1) return true;

            int[] dicindex = new int[26];
            for (int i = 0; i < order.Length; i++)
            {
                dicindex[order[i] - 'a'] = i;
            }
            Console.Write(string.Join(",", dicindex));

            for (int i = 1; i < words.Length; i++)
            {
                if (!IsRightOrder(words[i - 1], words[i], dicindex)) return false;
            }

            return true;
        }

        public static bool IsRightOrder(string word1, string word2, int[] dicindex)
        {
            int i = 0;

            while (i < word1.Length && i < word2.Length)
            {
                char first = word1[i];
                char Sec = word2[i];

                Console.WriteLine("Comparing {0} and {1} : ", first.ToString(), Sec.ToString());
                i++;
                if (first == Sec)
                {
                    continue;
                }
                else if (dicindex[first - 'a'] > dicindex[Sec - 'a'])
                {
                    return false;
                }
                else
                    return true;

            }

            if (word1.Length > word2.Length) return false;

            return true;
        }
    }
}
