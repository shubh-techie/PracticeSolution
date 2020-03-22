using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.Practice
{
    public class FrequencyCount
    {
        public static void anagramPalindromeTesting()
        {
            string str1 = "cat";

            Console.WriteLine(anagramPalindrome(str1));
        }


        public static bool anagramPalindrome(string str1)
        {
            int[] chars = new int[128];

            foreach (char c1 in str1)
            {
                chars[c1]++;
            }

            int odds = 0;
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] % 2 != 0)
                {
                    odds++;
                }
            }

            return odds < 2;
        }

        public static void characterMode()
        {
            string str = "noon";
            Console.WriteLine(characterMode(str));
        }

        public static string characterMode(string str)
        {
            // YOUR WORK HERE
            int[] chars = new int[128];
            string result = "";
            foreach (char c in str)
            {
                chars[c] += 1;
            }

            int maxCount = 0;
            for (int i = 0; i < chars.Length; i++)
            {
                maxCount = Math.Max(maxCount, chars[i]);
            }


            for (int c = 0; c < chars.Length; c++)
            {
                if (chars[c] == maxCount)
                {
                    result += (Char)c;
                }
            }


            return result;
        }

        public static void letterSort()
        {
            string str = "hello";
            Console.WriteLine(letterSort(str));
        }


        public static string letterSort(string str)
        {
            int[] chars = new int[128];
            string result = "";
            foreach (char c in str)
            {
                chars[c] += 1;
            }
            for (int i = 0; i < chars.Length; i++)
            {
                while (chars[i] > 0)
                {
                    char letter = (char)(i);
                    result += letter;
                    chars[i] -= 1;
                }
            }
            return result;
        }


        public static void anagramPairTesting()
        {
            string str1 = "cat";
            string str2 = "dog";

            Console.WriteLine(anagramPair(str1, str2));
        }


        public static bool anagramPair(string str1, string str2)
        {
            int[] chars = new int[128];

            foreach (char c1 in str1)
            {
                chars[c1]++;
            }

            foreach (char c2 in str2)
            {
                chars[c2]--;
                if (chars[c2] < 0)
                {
                    return false;
                }
            }

            return true;
        }


        public static void missingNumberTesting()
        {
            int[] Arr = new int[] { 4, 7, 1, 6 };
            int max = 8;
            List<int> results = missingNumber(max, Arr);
            foreach (var item in results)
            {
                Console.Write(item);
            }
        }


        public static List<int> missingNumber(int n, int[] arr)
        {
            List<int> missingNumbers = new List<int>();
            HashSet<int> records = new HashSet<int>();
            foreach (var item in arr)
            {
                records.Add(item);
            }

            for (int i = 1; i <= n; i++)
            {
                if (!records.Contains(i))
                    missingNumbers.Add(i);
            }
            return missingNumbers;
        }

        public static void rgbGesting()
        {
            string input = "rgbrgb"; //--2
            Console.WriteLine(rgb(input));
        }


        public static int rgb(string str)
        {
            //insert all values in dictionary

            Dictionary<char, int> CharTracing = new Dictionary<char, int>();

            foreach (var item in str)
            {
                if (CharTracing.ContainsKey(item))
                    CharTracing[item]++;
                else
                    CharTracing[item] = 1;

            }

            if (CharTracing.Count < 3) return 0;

            int resultCount = int.MaxValue;

            foreach (var item in CharTracing.Keys)
            {
                resultCount = CharTracing[item] < resultCount ? CharTracing[item] : resultCount;
            }

            return resultCount;
        }






        public static void wordCountTesting()
        {
            //string input1 = "The cat and the hat."; //-- > '{ the: 2, cat: 1, and: 1, hat: 1 }'`
            //string input2 = "As soon as possible.";//-- > '{ as: 2, soon: 1, possible: 1 }'`
            string input3 = "It's a man, it's a plane, it's superman!";//--> '{ its: 3, a: 2, man: 1, plane: 1, superman: 1 }
            Dictionary<string, int> WordCounResults = wordCount(input3);
            foreach (var item in WordCounResults)
            {
                Console.Write("{0}: {1}, ", item.Key, item.Value);
            }
        }

        public static Dictionary<string, int> wordCount(string sentence)
        {
            Dictionary<string, int> WordCounResults = new Dictionary<string, int>();

            // YOUR WORK HERE
            HashSet<char> charPunch = new HashSet<char>() { '?', '!', '.', '\'', ',' };

            string filteredSentence = "";
            foreach (char ch in sentence)
            {
                if (charPunch.Contains(ch) == false)
                {
                    filteredSentence += Char.ToLower(ch);
                }
            }


            string[] wordSentence = filteredSentence.Split();

            for (int i = 0; i < wordSentence.Length; i++)
            {
                string word = wordSentence[i].ToLower();
                if (WordCounResults.ContainsKey(wordSentence[i]))
                {
                    //int indexValue = WordCounResults[wordSentence[i]]++;
                    WordCounResults[wordSentence[i]]++;
                }
                else
                {
                    WordCounResults.Add(wordSentence[i], 1);
                }
            }

            return WordCounResults;

        }


        public static void findUniqueFromArray()
        {
            int[] Arr = { 1, 2, 4, 4, 5, 6 };
            printArry(Arr);
            int[] results = getUniqueFromArray(Arr);
            printArry(results);
        }

        private static int[] getUniqueFromArray(int[] arr)
        {
            HashSet<int> tracker = new HashSet<int>();
            List<int> results = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (!tracker.Contains(arr[i]))
                {
                    tracker.Add(arr[i]);
                    results.Add(arr[i]);
                }
            }
            return results.ToArray();
        }

        public static void printArry(int[] Arr)
        {
            printArrayHelper(Arr, 0);
            Console.WriteLine();
        }

        public static void printArrayHelper(int[] arr, int index)
        {
            if (index >= arr.Length)
            {
                return;
            }
            Console.Write(arr[index] + "   ");
            index = index + 1;
            printArrayHelper(arr, index);
        }
    }



}
