using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace LeetCodePractice
{
    public class Ques1249MinimumParentheses
    {

        public void MinRemoveToMakeValid()
        {
            string s = "lee(t(c)o)de)";
            Console.WriteLine(MinRemoveToMakeValid(s));
        }
        public string MinRemoveToMakeValid(string s)
        {
            string result = removeInvalidClosing(s, '(', ')');
            char[] resultArry = result.ToCharArray();
            Array.Reverse(resultArry);
            result = removeInvalidClosing(new string(resultArry), ')', '(');

            char[] resultArryfinal = result.ToCharArray();
            Array.Reverse(resultArryfinal);

            return new string(resultArryfinal);
        }

        private string removeInvalidClosing(string s, char open, char close)
        {
            StringBuilder sb = new StringBuilder();


            int balance = 0;
            foreach (char ch in s)
            {
                if (ch == open)
                {
                    balance++;
                }
                else if (ch == close)
                {
                    if (balance == 0) continue;
                    balance--;
                }
                sb.Append(ch);
            }

            //Console.Write(sb.ToString());
            return sb.ToString();
        }

      

    }
}
