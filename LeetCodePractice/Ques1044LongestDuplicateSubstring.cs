using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice
{
    /*
        1044. Longest Duplicate Substring
        Given a string S, consider all duplicated substrings: (contiguous) substrings of S that occur 2 or more times.  (The occurrences may overlap.)

        Return any duplicated substring that has the longest possible length.  (If S does not have a duplicated substring, the answer is "".)

 

        Example 1:

        Input: "banana"
        Output: "ana"
        Example 2:

        Input: "abcd"
        Output: "" 
    

    */
    public class Ques1044LongestDuplicateSubstring
    {
        public static int LongestRepeatingSubstring()
        {
            return 0;
        }

        public int LongestRepeatingSubstring(string S)
        {
            int n = S.Length;
            // binary search, L = repeating string length
            int left = 1, right = n;
            int L;

            while (left <= right)
            {
                L = left + (right - left) / 2;
                if (search(L, n, S) != -1)
                    left = L + 1;
                else right = L - 1;
            }

            return left - 1;
        }

        public int search(int L, int n, String S)
        {
            HashSet<string> seen = new HashSet<string>();
            String tmp;
            for (int start = 0; start < n - L + 1; ++start)
            {
                tmp = S.Substring(start, start + L);
                if (seen.Contains(tmp))
                    return start;
                seen.Add(tmp);
            }
            return -1;
        }



        public static void LongestDupSubstring()
        {
            SubString("banana");
            Console.WriteLine();
            Console.WriteLine();
            //string output = CheckDuplicate("moplvidmaagmsiyyrkchbyhivlqwqsjcgtumqscmxrxrvwsnjjvygrelcbjgbpounhuyealllginkitfaiviraqcycjmskrozcdqylbuejrgfnquercvghppljmojfvylcxakyjxnampmakyjbqgwbyokaybcuklkaqzawageypfqhhasetugatdaxpvtevrigynxbqodiyioapgxqkndujeranxgebnpgsukybyowbxhgpkwjfdywfkpufcxzzqiuglkakibbkobonunnzwbjktykebfcbobxdflnyzngheatpcvnhdwkkhnlwnjdnrmjaevqopvinnzgacjkbhvsdsvuuwwhwesgtdzuctshytyfugdqswvxisyxcxoihfgzxnidnfadphwumtgdfmhjkaryjxvfquucltmuoosamjwqqzeleaiplwcbbxjxxvgsnonoivbnmiwbnijkzgoenohqncjqnckxbhpvreasdyvffrolobxzrmrbvwkpdbfvbwwyibydhndmpvqyfmqjwosclwxhgxmwjiksjvsnwupraojuatksjfqkvvfroqxsraskbdbgtppjrnzpfzabmcczlwynwomebvrihxugvjmtrkzdwuafozjcfqacenabmmxzcueyqwvbtslhjeiopgbrbvfbnpmvlnyexopoahgmwplwxnxqzhucdieyvbgtkfmdeocamzenecqlbhqmdfrvpsqyxvkkyfrbyolzvcpcbkdprttijkzcrgciidavsmrczbollxbkytqjwbiupvsorvkorfriajdtsowenhpmdtvamkoqacwwlkqfdzorjtepwlemunyrghwlvjgaxbzawmikfhtaniwviqiaeinbsqidetfsdbgsydkxgwoqyztaqmyeefaihmgrbxzyheoegawthcsyyrpyvnhysynoaikwtvmwathsomddhltxpeuxettpbeftmmyrqclnzwljlpxazrzzdosemwmthcvgwtxtinffopqxbufjwsvhqamxpydcnpekqhsovvqugqhbgweaiheeicmkdtxltkalexbeftuxvwnxmqqjeyourvbdfikqnzdipmmmiltjapovlhkpunxljeutwhenrxyfeufmzipqvergdkwptkilwzdxlydxbjoxjzxwcfmznfqgoaemrrxuwpfkftwejubxkgjlizljoynvidqwxnvhngqakmmehtvykbjwrrrjvwnrteeoxmtygiiygynedvfzwkvmffghuduspyyrnftyvsvjstfohwwyxhmlfmwguxxzgwdzwlnnltpjvnzswhmbzgdwzhvbgkiddhirgljbflgvyksxgnsvztcywpvutqryzdeerlildbzmtsgnebvsjetdnfgikrbsktbrdamfccvcptfaaklmcaqmglneebpdxkvcwwpndrjqnpqgbgihsfeotgggkdbvcdwfjanvafvxsvvhzyncwlmqqsmledzfnxxfyvcmhtjreykqlrfiqlsqzraqgtmocijejneeezqxbtomkwugapwesrinfiaxwxradnuvbyssqkznwwpsbgatlsxfhpcidfgzrc");
            Console.WriteLine();
        }

        public static void SubString(String str)
        {
            int n = str.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.WriteLine($"i ={i}, j={j}");
                    //Console.WriteLine(str.Substring(i, j));
                }
            }
        }
        public static string LongestDupSubstring(string S)
        {
            HashSet<string> tracker = new HashSet<string>();
            return helper(S, "", 0, tracker);
        }

        public static string helper(string str, string output, int index, HashSet<string> tracker)
        {
            if (index == str.Length) return output;

            for (int i = 1; i <= str.Length - index; i++)
            {
                string temp = str.Substring(index, i);
                if (!tracker.Contains(temp))
                    tracker.Add(temp);
                else
                {
                    Console.WriteLine(temp);
                    if (temp.Length > output.Length)
                        output = temp;
                }
            }

            return helper(str, output, index + 1, tracker);
        }
    }
}
