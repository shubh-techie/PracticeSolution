using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice
{
    public class Ques67Add_Binary
    {
        public void addBinary()
        {
            string a = "1010";
            string b = "1011";
            Console.WriteLine(addBinary(a, b));
        }
        public String addBinary(String a, String b)
        {
            StringBuilder sb = new StringBuilder();
            int i = a.Length - 1, j = b.Length - 1, carry = 0;
            while (i >= 0 || j >= 0)
            {
                int sum = carry;
                if (j >= 0)
                {
                    Console.WriteLine(b[j]);
                    sum += b[j--] - '0';

                }
                if (i >= 0)
                {
                    Console.WriteLine(a[i]);
                    sum += a[i--] - '0';
                }
                sb.Append(sum % 2);
                carry = sum / 2;
            }
            if (carry != 0) sb.Append(carry);
            char[] reverse = sb.ToString().ToCharArray();
            Array.Reverse(reverse);
            return new string(reverse);
        }
    }
}
