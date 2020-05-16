using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice
{
    public class Ques49GroupAnagrams
    {
        public static void GroupAnagrams()
        {
            string[] strs = { "eat", "tea", "tan", "ate", "nat", "bat" };

            var output = GroupAnagrams(strs);

            foreach (var item in output)
            {
                foreach (var ou in item)
                {
                    Console.Write(ou + ",");

                }
                Console.WriteLine();
            }

        }
        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            if (strs == null || strs.Length == 0) return null;

            IList<IList<string>> output = new List<IList<string>>();
            Dictionary<string, IList<String>> track = new Dictionary<string, IList<String>>();

            foreach (var anaString in strs)
            {
                char[] chKey = new char[26];
                //adding the key 
                foreach (char c in anaString.ToCharArray()) chKey[c - 'a']++;

                string key = new string(chKey);
                if (!track.ContainsKey(key))
                    track.Add(key, new List<string>() { anaString });
                else
                    track[key].Add(anaString);
            }

            var values = track.Values;

            foreach (var item in values)
            {
                output.Add(item);
            }

            return output;
        }
    }
}
