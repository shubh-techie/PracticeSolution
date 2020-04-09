using System;
using System.Collections.Generic;
using System.Text;

namespace RecursionPractice
{
    public class LatticePathDemo
    {
        public static void compute()
        {
           // Console.WriteLine("No of lattice path : {0}", computeHelper(3 + 1, 2 + 1));
            Console.WriteLine("No of lattice path : {0}", computeHelperUsingDynamic(3 + 1, 2 + 1));
        }

        public static int computeHelper(int m, int n)
        {
            if (m == 1 || n == 1)
            {
                return 1;
            }
            return computeHelper(m - 1, n) + computeHelper(m, n - 1);
        }

        public int repeatedNumber(List<int> A)
        {
            int duplicateCount = 0;
            HashSet<int> track = new HashSet<int>();


            for (int i = 0; i < A.Count; i++)
            {
                track.Add(A[i]);
                if (track.Contains(A[i]))
                {
                    duplicateCount++;
                }

            }

            return duplicateCount == 0 ? -1 : duplicateCount;
        }

        public static int computeHelperUsingDynamic(int m, int n)
        {
            if (m == 1 && n == 1) return 0;

            int[,] count = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                count[i, 0] = 1;
            }
            for (int j = 0; j < n; j++)
            {
                count[0, j] = 1;
            }

            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    count[i, j] = count[i - 1, j] + count[i, j - 1];
                }
            }

            return count[m - 1, n - 1];
        }
    }
}
