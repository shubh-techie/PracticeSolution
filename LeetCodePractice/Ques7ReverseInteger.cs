using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice
{
    class Ques7ReverseInteger
    {
        public static void Reverse()
        {
            Console.WriteLine(Reverse(-123));
        }
        public static int Reverse(int x)
        {
            if (x == 0) return 0;
            bool isNegative = x < 0 ? true : false;
            if (isNegative)
                x = -x;
            long output = 0;
            while (x > 0)
            {
                output = output * 10 + (x % 10);
                x = x / 10;
            }
            if (output > Int32.MaxValue) return 0;
            return isNegative ? (int)-output : (int)output;
        }
    }
}
