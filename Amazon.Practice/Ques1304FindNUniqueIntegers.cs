using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.Practice
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
            int num = n / 2;
            int[] res = new int[5];

            for (var i = 1; i <= num; i++)
            {
                res[i] = -1;
            }

            if (n % 2 != 0)
            {
                res[n] = 0;
            }

            return res;
        }

    }
}


