using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicProgramming
{
    public class CoinChange
    {

        public static void countWays()
        {
            Console.WriteLine("No of ways " + countWays(new int[] { 1, 2, 3 }, 3, 5));
        }
        static long countWays(int[] S, int m, int n)
        {
            int[] count = new int[n + 1];

            count[0] = 1;

            for (int i = 0; i < m; i++)
            {
                for (int j = S[i]; j < n; j++)
                {
                    count[j] = count[j] + count[j - S[i]];
                }
                printArray(count, 0);

            }
           // printArray(S, 0);
            return count[n];
        }

        private static void printArray(int[] s, int index)
        {
            if (index == s.Length) return;
            Console.Write(s[index] + ",");
            printArray(s, index +1 );
            Console.WriteLine();
        }
    }
}
