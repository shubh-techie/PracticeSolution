using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice
{
    public class Ques20ValidParentheses
    {
        public static void IsValid()
        {
            Console.WriteLine("isValid :" + IsValidIWithDic("((((((())))"));
        }

        public static bool IsValidIWithDic(string s)
        {
            if (s.Length == 1) return false;

            Dictionary<char, int> mapping = new Dictionary<char, int>();
            mapping.Add('(', 0);
            mapping.Add('[', 0);
            mapping.Add('{', 0);

            Stack<int> stack = new Stack<int>();
            Dictionary<int, int> Track = new Dictionary<int, int>();

            foreach (var ch in s)
            {
                if (mapping.ContainsKey(ch))
                {
                    mapping[ch]++;
                }
                else
                {
                    if (ch == ')')
                    {
                        char temp = '(';
                        mapping[temp]--;
                    }
                    else if (ch == ']')
                    {
                        char temp = '[';
                        mapping[temp]--;
                    }
                    else if (ch == '}')
                    {
                        char temp = '{';
                        mapping[temp]--;
                    }
                }
            }
            int odds = 0;
            foreach (var item in mapping.Keys)
            {
                if (mapping[item] != 0)
                    odds++;
            }

            return odds > 0 ? false : true;
        }
        public static bool IsValid(string s)
        {
            if (s.Length == 1) return false;

            Dictionary<char, char> mapping = new Dictionary<char, char>();
            mapping.Add(')', '(');
            mapping.Add(']', '[');
            mapping.Add('}', '{');
            Stack<char> tracker = new Stack<char>();

            foreach (var ch in s)
            {
                if (mapping.ContainsKey(ch))
                {
                    char top = tracker.Count > 0 ? tracker.Pop() : '#';
                    if (top != mapping[ch])
                    {
                        return false;
                    }
                }
                else
                {
                    tracker.Push(ch);
                }
            }

            return tracker.Count > 0 ? false : true;
        }
        public static bool IsValid1(string s)
        {
            if (string.IsNullOrEmpty(s)) throw new Exception("enter a valid string");
            if (s.Length == 1) return false;

            Stack<char> tracker = new Stack<char>();

            foreach (var item in s)
            {
                if (item == '{' || item == '[' || item == '(')
                {
                    tracker.Push(item);
                }
                else
                {
                    //if (tracker.Count == 0) throw new Exception("Please provide a valid paranthaseses");
                    char top = tracker.Count > 0 ? tracker.Peek() : '#';

                    if ((item == ')' && top == '(') || (item == ']' && top == '[') || (item == '}' && top == '{'))
                    {
                        tracker.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return tracker.Count > 0 ? false : true;
        }
    }
}
