using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice
{
    public class Ques535EncodeandDecodeTinyURL
    {
        const string tinyConst = "http://tinyurl.com/";
        const string alpha = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

        private static Dictionary<string, string> keyStorage;
        Random randomNext;

        public Ques535EncodeandDecodeTinyURL()
        {
            keyStorage = new Dictionary<string, string>();
            randomNext = new Random();
        }

        public void encode()
        {
            string input = "https://leetcode.com/problems/design-tinyurl";
            string shortURL = encode(input);
            Console.WriteLine(shortURL);
            Console.WriteLine(decode(shortURL));
        }

        // Encodes a URL to a shortened URL
        public string encode(string longUrl)
        {
            string key = getRandom(longUrl);
            if (!keyStorage.ContainsKey(key))
                keyStorage.Add(key, longUrl);
            return "http://tinyurl.com/" + key;
        }

        private string getRandom(string longUrl)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 6; i++)
            {
                sb.Append(alpha[randomNext.Next(62)]);
            }
            return sb.ToString();
        }


        // Decodes a shortened URL to its original URL.
        public static string decode(string shortUrl)
        {
            //Console.WriteLine(HashSet[Convert.ToInt32(shortUrl.Replace("http://tinyurl.com/", ""))]);
            return keyStorage[shortUrl.Replace("http://tinyurl.com/", "")];
        }
    }
}
