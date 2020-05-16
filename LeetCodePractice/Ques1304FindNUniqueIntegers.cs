using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice
{
    public class Ques1304FindNUniqueIntegers
    {

        public static void SumZero()
        {
            int[] output = SumZero(5);

            foreach (var item in output)
            {
                Console.WriteLine(item);

            }

        }

        public static int[] SumZero(int n)
        {
            int[] res = new int[n];
            int sum = 0;
            for (int i = 0; i < res.Length - 1; i++)
            {
                res[i] = i;
                sum = sum + res[i];
            }
            res[n - 1] = -sum;
            return res;
        }

    }
}


